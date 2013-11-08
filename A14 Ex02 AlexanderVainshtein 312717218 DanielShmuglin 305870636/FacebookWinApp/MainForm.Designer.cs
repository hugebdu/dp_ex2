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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_NewsFeedGroup = new System.Windows.Forms.GroupBox();
            this.postRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.m_PostItemTemplate = new Ex2.FacebookApp.UserControls.PostItemControl();
            this.postMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_BookmarkItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.opeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_RefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataRepeater1 = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.postItemControl1 = new Ex2.FacebookApp.UserControls.PostItemControl();
            this.m_NewsFeedGroup.SuspendLayout();
            this.postRepeater.ItemTemplate.SuspendLayout();
            this.postRepeater.SuspendLayout();
            this.postMenuStrip.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_NewsFeedGroup
            // 
            this.m_NewsFeedGroup.Controls.Add(this.postRepeater);
            this.m_NewsFeedGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_NewsFeedGroup.Location = new System.Drawing.Point(3, 3);
            this.m_NewsFeedGroup.Name = "m_NewsFeedGroup";
            this.m_NewsFeedGroup.Size = new System.Drawing.Size(655, 356);
            this.m_NewsFeedGroup.TabIndex = 0;
            this.m_NewsFeedGroup.TabStop = false;
            // 
            // postRepeater
            // 
            this.postRepeater.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // postRepeater.ItemTemplate
            // 
            this.postRepeater.ItemTemplate.Controls.Add(this.m_PostItemTemplate);
            this.postRepeater.ItemTemplate.Size = new System.Drawing.Size(641, 115);
            this.postRepeater.Location = new System.Drawing.Point(3, 16);
            this.postRepeater.Name = "postRepeater";
            this.postRepeater.Size = new System.Drawing.Size(649, 337);
            this.postRepeater.TabIndex = 3;
            this.postRepeater.Text = "dataRepeater1";
            // 
            // m_PostItemTemplate
            // 
            this.m_PostItemTemplate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_PostItemTemplate.ContextMenuStrip = this.postMenuStrip;
            this.m_PostItemTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_PostItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.m_PostItemTemplate.Name = "m_PostItemTemplate";
            this.m_PostItemTemplate.Post = null;
            this.m_PostItemTemplate.Size = new System.Drawing.Size(626, 114);
            this.m_PostItemTemplate.TabIndex = 0;
            // 
            // postMenuStrip
            // 
            this.postMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_BookmarkItToolStripMenuItem});
            this.postMenuStrip.Name = "contextMenuStrip1";
            this.postMenuStrip.Size = new System.Drawing.Size(142, 26);
            // 
            // m_BookmarkItToolStripMenuItem
            // 
            this.m_BookmarkItToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("m_BookmarkItToolStripMenuItem.Image")));
            this.m_BookmarkItToolStripMenuItem.Name = "m_BookmarkItToolStripMenuItem";
            this.m_BookmarkItToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.m_BookmarkItToolStripMenuItem.Text = "Bookmark it!";
            this.m_BookmarkItToolStripMenuItem.Click += new System.EventHandler(this.m_BookmarkItToolStripMenuItem_Click);
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
            this.m_RefreshMenuItem,
            this.signOutToolStripMenuItem});
            this.opeToolStripMenuItem.Name = "opeToolStripMenuItem";
            this.opeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opeToolStripMenuItem.Text = "Actions";
            // 
            // m_RefreshMenuItem
            // 
            this.m_RefreshMenuItem.Name = "m_RefreshMenuItem";
            this.m_RefreshMenuItem.Size = new System.Drawing.Size(118, 22);
            this.m_RefreshMenuItem.Text = "Refresh";
            this.m_RefreshMenuItem.Click += new System.EventHandler(this.m_RefreshMenuItem_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(838, 388);
            this.splitContainer1.SplitterDistance = 669;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 388);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.m_NewsFeedGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Feed";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataRepeater1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Favorites";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.postItemControl1);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(647, 124);
            this.dataRepeater1.Location = new System.Drawing.Point(3, 3);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(655, 356);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "dataRepeater1";
            // 
            // postItemControl1
            // 
            this.postItemControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postItemControl1.Location = new System.Drawing.Point(0, 0);
            this.postItemControl1.Name = "postItemControl1";
            this.postItemControl1.Post = null;
            this.postItemControl1.Size = new System.Drawing.Size(632, 123);
            this.postItemControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 412);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Cool facebook app";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.m_NewsFeedGroup.ResumeLayout(false);
            this.postRepeater.ItemTemplate.ResumeLayout(false);
            this.postRepeater.ResumeLayout(false);
            this.postMenuStrip.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox m_NewsFeedGroup;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem opeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater postRepeater;
        private UserControls.PostItemControl m_PostItemTemplate;
        private System.Windows.Forms.ToolStripMenuItem m_RefreshMenuItem;
        private System.Windows.Forms.ContextMenuStrip postMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem m_BookmarkItToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
        private UserControls.PostItemControl postItemControl1;
    }
}