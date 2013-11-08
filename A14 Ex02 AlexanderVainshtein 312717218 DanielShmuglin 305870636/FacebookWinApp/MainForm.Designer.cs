namespace Ex2.FacebookApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.postRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.opeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_PostItemTemplate = new Ex2.FacebookApp.UserControls.PostItemControl();
            this.groupBox1.SuspendLayout();
            this.postRepeater.ItemTemplate.SuspendLayout();
            this.postRepeater.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.postRepeater);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Friends feed";
            // 
            // postRepeater
            // 
            this.postRepeater.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // postRepeater.ItemTemplate
            // 
            this.postRepeater.ItemTemplate.Controls.Add(this.m_PostItemTemplate);
            this.postRepeater.ItemTemplate.Size = new System.Drawing.Size(575, 115);
            this.postRepeater.Location = new System.Drawing.Point(3, 16);
            this.postRepeater.Name = "postRepeater";
            this.postRepeater.Size = new System.Drawing.Size(583, 369);
            this.postRepeater.TabIndex = 3;
            this.postRepeater.Text = "dataRepeater1";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opeToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(838, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "File";
            // 
            // opeToolStripMenuItem
            // 
            this.opeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.opeToolStripMenuItem.Name = "opeToolStripMenuItem";
            this.opeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opeToolStripMenuItem.Text = "Actions";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.signOutToolStripMenuItem.Text = "Sign out";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // m_PostItemTemplate
            // 
            this.m_PostItemTemplate.Author = "[User]";
            this.m_PostItemTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_PostItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.m_PostItemTemplate.Name = "m_PostItemTemplate";
            this.m_PostItemTemplate.PostText = "";
            this.m_PostItemTemplate.Size = new System.Drawing.Size(560, 114);
            this.m_PostItemTemplate.TabIndex = 0;
            this.m_PostItemTemplate.Userpic = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Cool facebook app";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.groupBox1.ResumeLayout(false);
            this.postRepeater.ItemTemplate.ResumeLayout(false);
            this.postRepeater.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem opeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater postRepeater;
        private UserControls.PostItemControl m_PostItemTemplate;
    }
}