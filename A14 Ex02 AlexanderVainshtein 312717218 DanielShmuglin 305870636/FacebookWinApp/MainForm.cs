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
            public string Author { get; set; }
            public string Text { get; set; }
            public Image Userpic { get; set; }
            public long LikesCount { get; set; }
        }

        private User m_User;

        private readonly Timer m_FeedRefreshTimer = new Timer();

        public MainForm(LoginResult i_LoginResult)
        {
            m_User = i_LoginResult.LoggedInUser;
            InitializeComponent();
            initializeTimer();
            m_FeedRefreshTimer.Interval = 30000;
            m_FeedRefreshTimer.Tick += new EventHandler(m_FeedRefreshTimer_Tick);
            m_FeedRefreshTimer.Start();
        }

        private void initializeTimer()
        {
            m_FeedRefreshTimer.Interval = 30000;
            m_FeedRefreshTimer.Tick += new EventHandler(m_FeedRefreshTimer_Tick);
            m_FeedRefreshTimer.Start();
        }
        
        private void MainWin_Load(object sender, EventArgs e)
        {
            new Task(loadNewsFeed).Start();
        }

        void m_FeedRefreshTimer_Tick(object sender, EventArgs e)
        {
            loadNewsFeed();
        }

        private void loadNewsFeed()
        {
            var postsInfo = m_User.NewsFeed.Select(post => new PostShortInfo()
            {
                Author = post.From.Name,
                Text = post.Message,
                Userpic = post.From.ImageNormal,
                LikesCount = post.LikesCount
            }).ToList();

            m_PostItemTemplate.DataBindings.Clear();
            m_PostItemTemplate.DataBindings.Add("Author", postsInfo, "Author");
            m_PostItemTemplate.DataBindings.Add("PostText", postsInfo, "Text");
            m_PostItemTemplate.DataBindings.Add("Userpic", postsInfo, "Userpic");
            m_PostItemTemplate.DataBindings.Add("LikesCount", postsInfo, "LikesCount");
            //m_PostItemTemplate.DataBindings.Add("Author", m_User.NewsFeed, "From.Name");
            //m_PostItemTemplate.DataBindings.Add("Userpic", m_User.NewsFeed, "From.ImageNormal");
            //m_PostItemTemplate.DataBindings.Add("PostText", m_User.NewsFeed, "Message");
            //postRepeater.DataSource = m_User.NewsFeed;

            //BindingSource bindingSource1 = new BindingSource();
            //bindingSource1.DataSource = items;
            //textBox1.DataBindings.Add("Text", bindingSource1, "FirstName");
            //label1.DataBindings.Add("Text", bindingSource1, "LastName");
            //postRepeater.DataSource = bindingSource1;

            // postRepeater.DataBindings

            if (postRepeater.InvokeRequired)
            {
                postRepeater.Invoke(new Action(() => postRepeater.DataSource = postsInfo ));
            }
            else
            {
                postRepeater.DataSource = postsInfo;
            }
        }
    }

   
}
