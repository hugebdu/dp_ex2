using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Ex2.FacebookApp.Translator;

namespace Ex2.FacebookApp.UserControls
{
    public partial class m_PostItemControl : UserControl
    {
        private LinkViewForm m_LinkViewForm;
        
        private UserForm m_UserForm;

        public ITranslatorHost TranslatorHost { get; set; }

        private bool m_PostIsTranslated;

        public m_PostItemControl()
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
                    m_PostIsTranslated = false;
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
            m_LikesCountLabel.Text = likesCount.ToString();
            m_UserPicture.Image = m_Post == null || m_Post.From == null ? null : m_Post.From.ImageNormal;
        }
        
        private void m_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_PostIsTranslated || TranslatorHost == null || TranslatorHost.ActiveTranslator == null)
            {
                return;
            }

            if (m_TabControl.SelectedTab == m_TranslatedTab)
            {
                TranslatorHost.ActiveTranslator.AsyncTranslate(m_PostBody.Text, (result) => Utils.UpdateControlText(m_TranslatedPostBody, result.TranslatedOrOriginText));
                m_PostIsTranslated = true;
            }
        }

        private void m_PostBody_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            ensureBrowserExists();
            m_LinkViewForm.Url = e.LinkText;
            m_LinkViewForm.Show();
        }

        private void m_Name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_Post != null)
            {
                ensureUserFromExists();
                m_UserForm.User = m_Post.From;
                m_UserForm.Show(this);
            }
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

        private void ensureUserFromExists()
        {
            if (m_UserForm != null)
            {
                return;
            }

            m_UserForm = new UserForm();
            m_UserForm.FormClosed += (sender, e) => m_UserForm = null;
        }

        private void m_ViewPostLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_Post != null)
            {
                var postUrl = string.Format("http://www.facebook.com/{0}", m_Post.Id);
                Process.Start(postUrl);
            }
        }
    }
}