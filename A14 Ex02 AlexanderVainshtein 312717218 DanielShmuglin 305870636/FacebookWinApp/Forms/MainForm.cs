using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.PowerPacks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Ex2.FacebookApp.UserControls;
using Ex2.FacebookApp.Translator;

namespace Ex2.FacebookApp
{
    public partial class MainForm : Form, ITranslatorHost
    {
        private const eTranslatorType k_DefaultTranslator = eTranslatorType.Dummy;

        private readonly FavoritesManager m_FavoritesManager;

        private readonly Timer m_FeedRefreshTimer = new Timer();

        private readonly Dictionary<eTranslatorType, ITranslator> m_Translators = new Dictionary<eTranslatorType, ITranslator>();

        private class PostWrapper
        {
            public Post Post { get; set; }

            public ITranslatorHost TranslatorHost { get; set; }

            public FavoritesManager FavoritesManager { get; set; }
        }

        private User m_User;

        private eTranslatorType m_TranslatorType = eTranslatorType.Dummy;

        public ITranslator ActiveTranslator
        {
            get
            {
                if (!m_Translators.ContainsKey(m_TranslatorType))
                {
                    m_Translators.Add(m_TranslatorType, TranslatorFactory.Create(m_TranslatorType, "ru"));
                }

                return m_Translators[m_TranslatorType];
            }
        }

        public MainForm(LoginResult i_LoginResult)
        {
            m_User = i_LoginResult.LoggedInUser;
            InitializeComponent();
            initializeTimer();

            m_FavoritesManager = new FavoritesManager(m_User.Id);
            m_FavoritesManager.FavoriteAdded += m_FavoritesManager_FavoriteAdded;
            m_FavoritesManager.FavoriteRemoved += m_FavoritesManager_FavoriteRemoved;
        }

        private void m_FavoritesManager_FavoriteRemoved(object i_Sender, Post i_Post)
        {
            var favoritePosts = m_FavoritesRepeater.DataSource as List<PostWrapper>;
            favoritePosts.RemoveAll(pw => pw.Post.Id == i_Post.Id);
            m_FavoritesRepeater.DataSource = new List<PostWrapper>(favoritePosts);
            updateFavoritesTabTitle(favoritePosts.Count);
        }

        private void m_FavoritesManager_FavoriteAdded(object i_Sender, Post i_Post)
        {
            loadFavoritesAsync();
        }

        private Control getControlForPost(Post i_Post)
        {
            foreach (Control control in m_FavoritesRepeater.Controls)
            {
                var postControl = control.Controls[0] as PostItemControl;
                if (postControl.Post.Id == i_Post.Id)
                {
                    return control;
                }
            }

            return null;
        }

        private void initializeTimer()
        {
            m_FeedRefreshTimer.Interval = 60000;
            m_FeedRefreshTimer.Tick += new EventHandler(m_FeedRefreshTimer_Tick);
            // m_FeedRefreshTimer.Start();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            loadNewFeedAsync();
            loadFavoritesAsync();
            createTranslatorsMenu();
        }

        void m_FeedRefreshTimer_Tick(object sender, EventArgs e)
        {
            loadNewsFeed();
        }

        private void loadNewFeedAsync()
        {
            new Task(loadNewsFeed).Start();
        }

        private void loadNewsFeed()
        {
            var posts = m_User.NewsFeed.Select(post => createPostWrapper(post)).ToList();
            updatePostRepeater(m_NewsFeedRepeater, m_PostItemTemplate, posts);
        }

        private void loadFavoritesAsync()
        {
            new Task(loadFavorites).Start();
        }

        private void loadFavorites()
        {
            var posts = m_FavoritesManager.GetFavoritePosts().Select(post => createPostWrapper(post)).ToList();
            updatePostRepeater(m_FavoritesRepeater, m_FavoritePostTemplate, posts);
            updateFavoritesTabTitle(posts.Count);
        }

        private PostWrapper createPostWrapper(Post i_Post)
        {
            return new PostWrapper()
                {
                    Post = i_Post,
                    TranslatorHost = this,
                    FavoritesManager = m_FavoritesManager
                };
        }

        private void updatePostRepeater(DataRepeater i_Repeater, Control template, List<PostWrapper> i_Posts)
        {
            template.DataBindings.Clear();
            template.DataBindings.Add("TranslatorHost", i_Posts, "TranslatorHost");
            template.DataBindings.Add("FavoritesManager", i_Posts, "FavoritesManager");
            template.DataBindings.Add("Post", i_Posts, "Post");

            if (i_Repeater.InvokeRequired)
            {
                i_Repeater.Invoke(new Action(() => i_Repeater.DataSource = i_Posts));
            }
            else
            {
                i_Repeater.DataSource = i_Posts;
            }
        }

        private void m_BookmarkItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sourceControl = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as PostItemControl;
            if (sourceControl != null && sourceControl.Post != null)
            {
                m_FavoritesManager.MarkFavorite(sourceControl.Post);
                loadFavoritesAsync();
            }
        }

        private void removeFromFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sourceControl = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as PostItemControl;
            if (sourceControl != null && sourceControl.Post != null)
            {
                m_FavoritesManager.UnmarkFavorite(sourceControl.Post);
                loadFavoritesAsync();
            }
        }

        private void reloadFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFavoritesAsync();
        }

        private void m_ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_RefreshNewsFeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadNewFeedAsync();
        }

        private void updateFavoritesTabTitle(int i_FavoritesCount)
        {
            Utils.UpdateControlText(m_FavoritesTabPage, string.Format("Favorites({0})", i_FavoritesCount));
        }

        private void createTranslatorsMenu()
        {
            foreach (var value in Enum.GetValues(typeof(eTranslatorType)))
            {
                var translatorType = (eTranslatorType)value;
                var menuItem = new ToolStripMenuItem(translatorType.ToString());
                menuItem.Click += translatorMenuItem_Click;
                menuItem.Checked = translatorType == k_DefaultTranslator;
                m_TranslatorToolStripMenuItem.DropDownItems.Add(menuItem);
            }
        }

        private void translatorMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                m_TranslatorType = (eTranslatorType)Enum.Parse(typeof(eTranslatorType), menuItem.Text);
                foreach (var item in m_TranslatorToolStripMenuItem.DropDownItems)
                {
                    (item as ToolStripMenuItem).Checked = item == menuItem;
                }
            }
        }
    }
}