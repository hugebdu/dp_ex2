using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex2.FacebookApp.UserControls
{
    public partial class PostItemControl : UserControl
    {
        private LinkViewForm m_LinkViewForm;

        public PostItemControl()
        {
            InitializeComponent();
        }

        private Post m_Post;
        public Post Post
        {
            get
            {
                return m_Post;
            }
            set
            {
                if (m_Post != value)
                {
                    m_Post = value;
                    updateView();
                }
            }
        }


        private void updateView()
        {
            long likesCount = 0;
            if (m_Post != null)
            {
                if ((m_Post as PostedItem).LikedBy != null)
                {
                    likesCount = (m_Post as PostedItem).LikedBy.Count;
                }
                else
                {
                    likesCount = m_Post.LikesCount;
                }
            }

            m_PostBody.Text = m_Post == null ? string.Empty : m_Post.Message;
            m_Name.Text = m_Post == null || m_Post.From == null ? string.Empty : m_Post.From.Name;
            m_LikesCountLink.Text = likesCount.ToString();
            m_UserPicture.Image = m_Post == null || m_Post.From == null ? null : m_Post.From.ImageNormal;
        }

        private void m_LikesCountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_Post != null)
            {

            }
        }

        private void m_PostBody_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            ensureBrowserExists();
            m_LinkViewForm.Url = e.LinkText;
            m_LinkViewForm.Show();
        }

        private void ensureBrowserExists()
        {
            if (m_LinkViewForm != null)
            {
                return;
            }

            m_LinkViewForm = new LinkViewForm();
            m_LinkViewForm.FormClosed += (sender, e) => m_LinkViewForm = null;
        }
    }
}