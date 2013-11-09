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
    public partial class LinkViewer : UserControl
    {
        public LinkViewer()
        {
            InitializeComponent();
        }

        public string Url
        {
            get
            {
                return m_WebBrowser.Url != null ? m_WebBrowser.Url.ToString() : null;
            }
            set
            {
                //Uri uri;
                //if (Uri.TryCreate(value, UriKind.Absolute, out uri))
                //{
                //    m_WebBrowser.Url = uri;
                    
                //}

                m_WebBrowser.Navigate(value);
            }
        }
    }
}
