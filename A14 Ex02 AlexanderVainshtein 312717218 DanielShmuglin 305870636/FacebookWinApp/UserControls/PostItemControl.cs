using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Ex2.FacebookApp.Translator;

namespace Ex2.FacebookApp.UserControls
{
    public partial class m_PostItemControl : UserControl
    {
        private LinkViewForm m_LinkViewForm;

        public ITranslator Translator { get; set; }

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
            m_LikesCountLink.Text = likesCount.ToString();
            m_UserPicture.Image = m_Post == null || m_Post.From == null ? null : m_Post.From.ImageNormal;
        }

        private void updateControlText(Control i_Control, string i_Text)
        {
            if (i_Control.InvokeRequired)
            {
                i_Control.Invoke(new Action<Control, string>(this.updateControlText), i_Control, i_Text);
            }
            else
            {
                i_Control.Text = i_Text;
            }
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

        private void m_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_PostIsTranslated || Translator == null)
            {
                return;
            }

            if (m_TabControl.SelectedTab == m_TranslatedTab)
            {
                Translator.AsyncTranslate(m_PostBody.Text, (result) => this.updateControlText(m_TranslatedPostBody, result.TranslatedOrOriginText));
            }
        }
    }
}