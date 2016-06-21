﻿namespace GMusicProxyGui
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlSR = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxArtist = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgDownloadListCover = new System.Windows.Forms.ImageList(this.components);
            this.pnlResultControlls = new System.Windows.Forms.Panel();
            this.btnAddDownload = new System.Windows.Forms.Button();
            this.tabPageDownload = new System.Windows.Forms.TabPage();
            this.listViewDownload = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlDownloadControls = new System.Windows.Forms.Panel();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.btnDownload = new System.Windows.Forms.Button();
            this.imgResultListCover = new System.Windows.Forms.ImageList(this.components);
            this.btnRemoveDownload = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.tabControlSR.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.pnlResultControlls.SuspendLayout();
            this.tabPageDownload.SuspendLayout();
            this.pnlDownloadControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(533, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistTitleToolStripMenuItem,
            this.titleArtistToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.importToolStripMenuItem.Text = "Import list";
            // 
            // artistTitleToolStripMenuItem
            // 
            this.artistTitleToolStripMenuItem.Name = "artistTitleToolStripMenuItem";
            this.artistTitleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.artistTitleToolStripMenuItem.Text = "Artist - Title";
            this.artistTitleToolStripMenuItem.Click += new System.EventHandler(this.artistTitleToolStripMenuItem_Click);
            // 
            // titleArtistToolStripMenuItem
            // 
            this.titleArtistToolStripMenuItem.Name = "titleArtistToolStripMenuItem";
            this.titleArtistToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.titleArtistToolStripMenuItem.Text = "Title - Artist";
            this.titleArtistToolStripMenuItem.Click += new System.EventHandler(this.titleArtistToolStripMenuItem_Click);
            // 
            // tabControlSR
            // 
            this.tabControlSR.Controls.Add(this.tabPageSearch);
            this.tabControlSR.Controls.Add(this.tabPageResult);
            this.tabControlSR.Controls.Add(this.tabPageDownload);
            this.tabControlSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSR.Location = new System.Drawing.Point(0, 24);
            this.tabControlSR.Name = "tabControlSR";
            this.tabControlSR.SelectedIndex = 0;
            this.tabControlSR.Size = new System.Drawing.Size(533, 387);
            this.tabControlSR.TabIndex = 2;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Controls.Add(this.txtBoxArtist);
            this.tabPageSearch.Controls.Add(this.txtBoxTitle);
            this.tabPageSearch.Controls.Add(this.lblArtist);
            this.tabPageSearch.Controls.Add(this.lblTitle);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(525, 361);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(442, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxArtist
            // 
            this.txtBoxArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxArtist.Location = new System.Drawing.Point(119, 54);
            this.txtBoxArtist.Name = "txtBoxArtist";
            this.txtBoxArtist.Size = new System.Drawing.Size(398, 20);
            this.txtBoxArtist.TabIndex = 10;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTitle.Location = new System.Drawing.Point(119, 13);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(398, 20);
            this.txtBoxTitle.TabIndex = 9;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(6, 54);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(33, 13);
            this.lblArtist.TabIndex = 8;
            this.lblArtist.Text = "Artist:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title:";
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.listViewResult);
            this.tabPageResult.Controls.Add(this.pnlResultControlls);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(525, 361);
            this.tabPageResult.TabIndex = 2;
            this.tabPageResult.Text = "Result";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // listViewResult
            // 
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.Location = new System.Drawing.Point(3, 31);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.ShowGroups = false;
            this.listViewResult.Size = new System.Drawing.Size(519, 327);
            this.listViewResult.SmallImageList = this.imgDownloadListCover;
            this.listViewResult.TabIndex = 0;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            this.listViewResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewResult_KeyDown);
            this.listViewResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewResult_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Artist";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Album";
            // 
            // imgDownloadListCover
            // 
            this.imgDownloadListCover.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgDownloadListCover.ImageSize = new System.Drawing.Size(64, 64);
            this.imgDownloadListCover.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlResultControlls
            // 
            this.pnlResultControlls.Controls.Add(this.btnAddDownload);
            this.pnlResultControlls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResultControlls.Location = new System.Drawing.Point(3, 3);
            this.pnlResultControlls.Name = "pnlResultControlls";
            this.pnlResultControlls.Size = new System.Drawing.Size(519, 28);
            this.pnlResultControlls.TabIndex = 1;
            // 
            // btnAddDownload
            // 
            this.btnAddDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDownload.Location = new System.Drawing.Point(350, 3);
            this.btnAddDownload.Name = "btnAddDownload";
            this.btnAddDownload.Size = new System.Drawing.Size(164, 23);
            this.btnAddDownload.TabIndex = 0;
            this.btnAddDownload.Text = "Add to download";
            this.btnAddDownload.UseVisualStyleBackColor = true;
            this.btnAddDownload.Click += new System.EventHandler(this.btnAddDownload_Click);
            // 
            // tabPageDownload
            // 
            this.tabPageDownload.Controls.Add(this.listViewDownload);
            this.tabPageDownload.Controls.Add(this.pnlDownloadControls);
            this.tabPageDownload.Location = new System.Drawing.Point(4, 22);
            this.tabPageDownload.Name = "tabPageDownload";
            this.tabPageDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDownload.Size = new System.Drawing.Size(525, 361);
            this.tabPageDownload.TabIndex = 1;
            this.tabPageDownload.Text = "Download";
            this.tabPageDownload.UseVisualStyleBackColor = true;
            // 
            // listViewDownload
            // 
            this.listViewDownload.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderArtist,
            this.columnHeaderAlbum});
            this.listViewDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDownload.FullRowSelect = true;
            this.listViewDownload.Location = new System.Drawing.Point(3, 31);
            this.listViewDownload.Name = "listViewDownload";
            this.listViewDownload.ShowGroups = false;
            this.listViewDownload.Size = new System.Drawing.Size(519, 327);
            this.listViewDownload.SmallImageList = this.imgDownloadListCover;
            this.listViewDownload.TabIndex = 0;
            this.listViewDownload.UseCompatibleStateImageBehavior = false;
            this.listViewDownload.View = System.Windows.Forms.View.Details;
            this.listViewDownload.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewDownload_KeyDown);
            this.listViewDownload.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewDownload_MouseDoubleClick);
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            // 
            // columnHeaderArtist
            // 
            this.columnHeaderArtist.Text = "Artist";
            // 
            // columnHeaderAlbum
            // 
            this.columnHeaderAlbum.Text = "Album";
            // 
            // pnlDownloadControls
            // 
            this.pnlDownloadControls.Controls.Add(this.btnRemoveDownload);
            this.pnlDownloadControls.Controls.Add(this.progressBarDownload);
            this.pnlDownloadControls.Controls.Add(this.btnDownload);
            this.pnlDownloadControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDownloadControls.Location = new System.Drawing.Point(3, 3);
            this.pnlDownloadControls.Name = "pnlDownloadControls";
            this.pnlDownloadControls.Size = new System.Drawing.Size(519, 28);
            this.pnlDownloadControls.TabIndex = 1;
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarDownload.Enabled = false;
            this.progressBarDownload.Location = new System.Drawing.Point(5, 3);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(313, 23);
            this.progressBarDownload.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Location = new System.Drawing.Point(439, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // imgResultListCover
            // 
            this.imgResultListCover.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgResultListCover.ImageSize = new System.Drawing.Size(64, 64);
            this.imgResultListCover.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRemoveDownload
            // 
            this.btnRemoveDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDownload.Location = new System.Drawing.Point(324, 3);
            this.btnRemoveDownload.Name = "btnRemoveDownload";
            this.btnRemoveDownload.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveDownload.TabIndex = 2;
            this.btnRemoveDownload.Text = "Remove from list";
            this.btnRemoveDownload.UseVisualStyleBackColor = true;
            this.btnRemoveDownload.Click += new System.EventHandler(this.btnRemoveDownload_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 411);
            this.Controls.Add(this.tabControlSR);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GMusicProxyGui";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabControlSR.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageResult.ResumeLayout(false);
            this.pnlResultControlls.ResumeLayout(false);
            this.tabPageDownload.ResumeLayout(false);
            this.pnlDownloadControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlSR;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxArtist;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tabPageDownload;
        private System.Windows.Forms.ListView listViewDownload;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderAlbum;
        private System.Windows.Forms.ColumnHeader columnHeaderArtist;
        private System.Windows.Forms.ImageList imgDownloadListCover;
        private System.Windows.Forms.Panel pnlDownloadControls;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleArtistToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel pnlResultControlls;
        private System.Windows.Forms.Button btnAddDownload;
        private System.Windows.Forms.ImageList imgResultListCover;
        private System.Windows.Forms.Button btnRemoveDownload;
    }
}

