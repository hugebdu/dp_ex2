namespace Ex2.FacebookApp.UserControls
{
    partial class PostItemControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_UserPicture = new System.Windows.Forms.PictureBox();
            this.m_Name = new System.Windows.Forms.LinkLabel();
            this.m_BodyPannel = new System.Windows.Forms.Panel();
            this.m_LikesCountLink = new System.Windows.Forms.LinkLabel();
            this.m_PostBody = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_UserPicture)).BeginInit();
            this.m_BodyPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_UserPicture
            // 
            this.m_UserPicture.Location = new System.Drawing.Point(4, 4);
            this.m_UserPicture.Name = "m_UserPicture";
            this.m_UserPicture.Size = new System.Drawing.Size(98, 73);
            this.m_UserPicture.TabIndex = 0;
            this.m_UserPicture.TabStop = false;
            // 
            // m_Name
            // 
            this.m_Name.AutoSize = true;
            this.m_Name.Location = new System.Drawing.Point(3, 87);
            this.m_Name.Name = "m_Name";
            this.m_Name.Size = new System.Drawing.Size(35, 13);
            this.m_Name.TabIndex = 2;
            this.m_Name.TabStop = true;
            this.m_Name.Text = "[User]";
            // 
            // m_BodyPannel
            // 
            this.m_BodyPannel.Controls.Add(this.m_LikesCountLink);
            this.m_BodyPannel.Controls.Add(this.m_PostBody);
            this.m_BodyPannel.Location = new System.Drawing.Point(108, 4);
            this.m_BodyPannel.Name = "m_BodyPannel";
            this.m_BodyPannel.Size = new System.Drawing.Size(434, 100);
            this.m_BodyPannel.TabIndex = 3;
            // 
            // m_LikesCountLink
            // 
            this.m_LikesCountLink.AutoSize = true;
            this.m_LikesCountLink.Location = new System.Drawing.Point(373, 15);
            this.m_LikesCountLink.Name = "m_LikesCountLink";
            this.m_LikesCountLink.Size = new System.Drawing.Size(32, 13);
            this.m_LikesCountLink.TabIndex = 4;
            this.m_LikesCountLink.TabStop = true;
            this.m_LikesCountLink.Text = "Likes";
            this.m_LikesCountLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.m_LikesCountLink_LinkClicked);
            // 
            // m_PostBody
            // 
            this.m_PostBody.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_PostBody.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_PostBody.Location = new System.Drawing.Point(0, 0);
            this.m_PostBody.Name = "m_PostBody";
            this.m_PostBody.ReadOnly = true;
            this.m_PostBody.Size = new System.Drawing.Size(354, 100);
            this.m_PostBody.TabIndex = 0;
            this.m_PostBody.Text = "";
            this.m_PostBody.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.m_PostBody_LinkClicked);
            // 
            // PostItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_BodyPannel);
            this.Controls.Add(this.m_Name);
            this.Controls.Add(this.m_UserPicture);
            this.DoubleBuffered = true;
            this.Name = "PostItemControl";
            this.Size = new System.Drawing.Size(545, 145);
            ((System.ComponentModel.ISupportInitialize)(this.m_UserPicture)).EndInit();
            this.m_BodyPannel.ResumeLayout(false);
            this.m_BodyPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_UserPicture;
        private System.Windows.Forms.Panel m_BodyPannel;
        private System.Windows.Forms.LinkLabel m_LikesCountLink;
        private System.Windows.Forms.RichTextBox m_PostBody;
        private System.Windows.Forms.LinkLabel m_Name;
    }
}
