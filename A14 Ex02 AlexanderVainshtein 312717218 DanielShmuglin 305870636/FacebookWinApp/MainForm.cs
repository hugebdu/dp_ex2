using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Ex2.FacebookApp.UserControls;

namespace Ex2.FacebookApp
{
    public partial class MainForm : Form
    {
        public class PostShortInfo
        {
            public Post Post { get; set; }
        }

        private User m_User;

        private readonly Timer m_FeedRefreshTimer = new Timer();

        public MainForm(LoginResult i_LoginResult)
        {
            m_User = i_LoginResult.LoggedInUser;
            InitializeComponent();
            initializeTimer();
        }

        private void initializeTimer()
        {
            m_FeedRefreshTimer.Interval = 30000;
            m_FeedRefreshTimer.Tick += new EventHandler(m_FeedRefreshTimer_Tick);
            m_FeedRefreshTimer.Start();
        }
        
        private void MainWin_Load(object sender, EventArgs e)
        {
            loadNewFeedAsync();
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
            var postsInfo = m_User.NewsFeed.Select(post => new PostShortInfo()
            {
                Post = post
            }).ToList();

            m_PostItemTemplate.DataBindings.Clear();
            m_PostItemTemplate.DataBindings.Add("Post", postsInfo, "Post");

            if (postRepeater.InvokeRequired)
            {
                postRepeater.Invoke(new Action(() => postRepeater.DataSource = postsInfo));
            }
            else
            {
                postRepeater.DataSource = postsInfo;
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
                MessageBox.Show("Bookmarked!");
                try
                {
                    var ans = FacebookWrapper.FacebookService.GetObject<Post>(sourceControl.Post.Id);
                    MessageBox.Show(ans.Caption);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

   
}
