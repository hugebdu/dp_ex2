using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex2.FacebookApp.UserControls
{
    public partial class PostItemControl : UserControl
    {
        public PostItemControl()
        {
            InitializeComponent();
        }

        public string Author
        {
            get
            {
                return
                  m_Name.Text;
            }
            set
            {
                m_Name.Text = value;
            }
        }

        public string PostText
        {
            get
            {
                return
                  m_PostBody.Text;
            }
            set
            {
                m_PostBody.Text = value;
            }
        }

        public Image Userpic
        {
            get
            {
                return m_UserPicture.Image;
            }
            set
            {
                m_UserPicture.Image = value;
            }
        }

        public long LikesCount
        {
            get
            {
                long count;
                long.TryParse(m_LikesCountLink.Text, out count);
                return count;
            }
            set
            {
                m_LikesCountLink.Text = value.ToString();
            }
        }
    }
}