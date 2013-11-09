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
            this.m_NewsFeedRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.postMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.opeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_RefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.m_FavoritesRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.m_BookmarkItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_PostItemTemplate = new Ex2.FacebookApp.UserControls.PostItemControl();
            this.m_FavoritePostTemplate = new Ex2.FacebookApp.UserControls.PostItemControl();
            this.m_NewsFeedRepeater.ItemTemplate.SuspendLayout();
            this.m_NewsFeedRepeater.SuspendLayout();
            this.postMenuStrip.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.m_FavoritesRepeater.ItemTemplate.SuspendLayout();
            this.m_FavoritesRepeater.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_NewsFeedRepeater
            // 
            this.m_NewsFeedRepeater.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // m_NewsFeedRepeater.ItemTemplate
            // 
            this.m_NewsFeedRepeater.ItemTemplate.Controls.Add(this.m_PostItemTemplate);
            this.m_NewsFeedRepeater.ItemTemplate.Size = new System.Drawing.Size(816, 115);
            this.m_NewsFeedRepeater.Location = new System.Drawing.Point(3, 3);
            this.m_NewsFeedRepeater.Name = "m_NewsFeedRepeater";
            this.m_NewsFeedRepeater.Size = new System.Drawing.Size(824, 356);
            this.m_NewsFeedRepeater.TabIndex = 3;
            // 
            // postMenuStrip
            // 
            this.postMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_BookmarkItToolStripMenuItem});
            this.postMenuStrip.Name = "contextMenuStrip1";
            this.postMenuStrip.Size = new System.Drawing.Size(142, 26);
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
            this.m_RefreshMenuItem.Size = new System.Drawing.Size(152, 22);
            this.m_RefreshMenuItem.Text = "Refresh";
            this.m_RefreshMenuItem.Click += new System.EventHandler(this.m_RefreshMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.signOutToolStripMenuItem.Text = "Sign out";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadFavoritesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // reloadFavoritesToolStripMenuItem
            // 
            this.reloadFavoritesToolStripMenuItem.Name = "reloadFavoritesToolStripMenuItem";
            this.reloadFavoritesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.reloadFavoritesToolStripMenuItem.Text = "Reload favorites";
            this.reloadFavoritesToolStripMenuItem.Click += new System.EventHandler(this.reloadFavoritesToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 388);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.m_NewsFeedRepeater);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(830, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Feed";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.m_FavoritesRepeater);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Favorites";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // m_FavoritesRepeater
            // 
            this.m_FavoritesRepeater.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // m_FavoritesRepeater.ItemTemplate
            // 
            this.m_FavoritesRepeater.ItemTemplate.Controls.Add(this.m_FavoritePostTemplate);
            this.m_FavoritesRepeater.ItemTemplate.Size = new System.Drawing.Size(816, 124);
            this.m_FavoritesRepeater.Location = new System.Drawing.Point(3, 3);
            this.m_FavoritesRepeater.Name = "m_FavoritesRepeater";
            this.m_FavoritesRepeater.Size = new System.Drawing.Size(824, 356);
            this.m_FavoritesRepeater.TabIndex = 0;
            this.m_FavoritesRepeater.Text = "dataRepeater1";
            // 
            // m_BookmarkItToolStripMenuItem
            // 
            this.m_BookmarkItToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("m_BookmarkItToolStripMenuItem.Image")));
            this.m_BookmarkItToolStripMenuItem.Name = "m_BookmarkItToolStripMenuItem";
            this.m_BookmarkItToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.m_BookmarkItToolStripMenuItem.Text = "Bookmark it!";
            this.m_BookmarkItToolStripMenuItem.Click += new System.EventHandler(this.m_BookmarkItToolStripMenuItem_Click);
            // 
            // m_PostItemTemplate
            // 
            this.m_PostItemTemplate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_PostItemTemplate.ContextMenuStrip = this.postMenuStrip;
            this.m_PostItemTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_PostItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.m_PostItemTemplate.Name = "m_PostItemTemplate";
            this.m_PostItemTemplate.Post = null;
            this.m_PostItemTemplate.Size = new System.Drawing.Size(801, 114);
            this.m_PostItemTemplate.TabIndex = 0;
            // 
            // m_FavoritePostTemplate
            // 
            this.m_FavoritePostTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_FavoritePostTemplate.Location = new System.Drawing.Point(0, 0);
            this.m_FavoritePostTemplate.Name = "m_FavoritePostTemplate";
            this.m_FavoritePostTemplate.Post = null;
            this.m_FavoritePostTemplate.Size = new System.Drawing.Size(801, 123);
            this.m_FavoritePostTemplate.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 412);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Cool facebook app";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.m_NewsFeedRepeater.ItemTemplate.ResumeLayout(false);
            this.m_NewsFeedRepeater.ResumeLayout(false);
            this.postMenuStrip.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.m_FavoritesRepeater.ItemTemplate.ResumeLayout(false);
            this.m_FavoritesRepeater.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem opeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater m_NewsFeedRepeater;
        private UserControls.PostItemControl m_PostItemTemplate;
        private System.Windows.Forms.ToolStripMenuItem m_RefreshMenuItem;
        private System.Windows.Forms.ContextMenuStrip postMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem m_BookmarkItToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater m_FavoritesRepeater;
        private UserControls.PostItemControl m_FavoritePostTemplate;
        private System.Windows.Forms.ToolStripMenuItem reloadFavoritesToolStripMenuItem;
    }
}