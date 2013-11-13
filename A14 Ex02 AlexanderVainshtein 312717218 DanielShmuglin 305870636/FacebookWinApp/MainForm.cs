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
    public partial class MainForm : Form
    {
        private class PostWrapper
        {
            public Post Post { get; set; }
        }

        private User m_User;

        private readonly FavoritesManager m_FavoritesManager = new FavoritesManager();

        private readonly Timer m_FeedRefreshTimer = new Timer();

        public readonly ITranslator Translator;

        public MainForm(LoginResult i_LoginResult)
        {
            m_User = i_LoginResult.LoggedInUser;
            InitializeComponent();
            initializeTimer();
            Translator = TranslatorFactory.Create("ru");
        }

        private void initializeTimer()
        {
            m_FeedRefreshTimer.Interval = 30000;
            m_FeedRefreshTimer.Tick += new EventHandler(m_FeedRefreshTimer_Tick);
            // m_FeedRefreshTimer.Start();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            loadNewFeedAsync();
            loadFavoritesAsync();
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
           var posts = m_User.NewsFeed.Take(10).Select(post => new PostWrapper()
            {
                Post = post
            }).ToList();

            updatePostRepeater(m_NewsFeedRepeater, m_PostItemTemplate, posts);
        }

        private void loadFavoritesAsync()
        {
            new Task(loadFavorites).Start();
        }

        private void loadFavorites()
        {
            var posts = m_FavoritesManager.GetFavoritePosts().Select(post => new PostWrapper { Post = post }).ToList();
            updatePostRepeater(m_FavoritesRepeater, m_FavoritePostTemplate, posts);
        }

        private void updatePostRepeater(DataRepeater i_Repeater, Control template, List<PostWrapper> i_Posts)
        {
            template.DataBindings.Clear();
            template.DataBindings.Add("Translator", this, "Translator");
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

        private void m_RefreshMenuItem_Click(object sender, EventArgs e)
        {
            loadNewFeedAsync();
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

    }
}
