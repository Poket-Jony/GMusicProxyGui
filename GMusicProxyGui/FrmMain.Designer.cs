namespace GMusicProxyGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlSR = new MetroFramework.Controls.MetroTabControl();
            this.tabPageSearch = new MetroFramework.Controls.MetroTabPage();
            this.btnGetMyStations = new MetroFramework.Controls.MetroButton();
            this.btnMixSearch = new MetroFramework.Controls.MetroButton();
            this.btnGetMyPlaylists = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtBoxArtist = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxTitle = new MetroFramework.Controls.MetroTextBox();
            this.lblArtist = new MetroFramework.Controls.MetroLabel();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.tabPageResult = new MetroFramework.Controls.MetroTabPage();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgResultListCover = new System.Windows.Forms.ImageList(this.components);
            this.pnlResultControlls = new MetroFramework.Controls.MetroPanel();
            this.btnAddDownload = new MetroFramework.Controls.MetroButton();
            this.tabPageDownload = new MetroFramework.Controls.MetroTabPage();
            this.listViewDownload = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgDownloadListCover = new System.Windows.Forms.ImageList(this.components);
            this.pnlDownloadControls = new MetroFramework.Controls.MetroPanel();
            this.btnRemoveDownload = new MetroFramework.Controls.MetroButton();
            this.progressBarDownload = new MetroFramework.Controls.MetroProgressBar();
            this.btnDownload = new MetroFramework.Controls.MetroButton();
            this.tabPagePlaylist = new MetroFramework.Controls.MetroTabPage();
            this.listViewPlaylist = new System.Windows.Forms.ListView();
            this.columnHeaderPlaylistTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPlaylistControls = new MetroFramework.Controls.MetroPanel();
            this.btnOpenPlaylist = new MetroFramework.Controls.MetroButton();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.controlPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.tabControlSR.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.pnlResultControlls.SuspendLayout();
            this.tabPageDownload.SuspendLayout();
            this.pnlDownloadControls.SuspendLayout();
            this.tabPagePlaylist.SuspendLayout();
            this.pnlPlaylistControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.importToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(20, 444);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(607, 24);
            this.menu.TabIndex = 0;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistTitleToolStripMenuItem,
            this.titleArtistToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installerToolStripMenuItem,
            this.configToolStripMenuItem,
            this.controlPanelToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // installerToolStripMenuItem
            // 
            this.installerToolStripMenuItem.Name = "installerToolStripMenuItem";
            this.installerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.installerToolStripMenuItem.Text = "Installer";
            this.installerToolStripMenuItem.Click += new System.EventHandler(this.installerToolStripMenuItem_Click);
            // 
            // tabControlSR
            // 
            this.tabControlSR.Controls.Add(this.tabPageSearch);
            this.tabControlSR.Controls.Add(this.tabPageResult);
            this.tabControlSR.Controls.Add(this.tabPageDownload);
            this.tabControlSR.Controls.Add(this.tabPagePlaylist);
            this.tabControlSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSR.Location = new System.Drawing.Point(20, 60);
            this.tabControlSR.Name = "tabControlSR";
            this.tabControlSR.SelectedIndex = 0;
            this.tabControlSR.Size = new System.Drawing.Size(607, 384);
            this.tabControlSR.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabControlSR.TabIndex = 2;
            this.tabControlSR.UseSelectable = true;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.btnGetMyStations);
            this.tabPageSearch.Controls.Add(this.btnMixSearch);
            this.tabPageSearch.Controls.Add(this.btnGetMyPlaylists);
            this.tabPageSearch.Controls.Add(this.btnSearch);
            this.tabPageSearch.Controls.Add(this.txtBoxArtist);
            this.tabPageSearch.Controls.Add(this.txtBoxTitle);
            this.tabPageSearch.Controls.Add(this.lblArtist);
            this.tabPageSearch.Controls.Add(this.lblTitle);
            this.tabPageSearch.HorizontalScrollbarBarColor = true;
            this.tabPageSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageSearch.HorizontalScrollbarSize = 10;
            this.tabPageSearch.Location = new System.Drawing.Point(4, 38);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(599, 342);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            this.tabPageSearch.VerticalScrollbarBarColor = true;
            this.tabPageSearch.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageSearch.VerticalScrollbarSize = 10;
            // 
            // btnGetMyStations
            // 
            this.btnGetMyStations.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnGetMyStations.Location = new System.Drawing.Point(235, 94);
            this.btnGetMyStations.Name = "btnGetMyStations";
            this.btnGetMyStations.Size = new System.Drawing.Size(109, 23);
            this.btnGetMyStations.TabIndex = 14;
            this.btnGetMyStations.Text = "Get my stations";
            this.btnGetMyStations.UseSelectable = true;
            this.btnGetMyStations.Click += new System.EventHandler(this.btnGetMyStations_Click);
            // 
            // btnMixSearch
            // 
            this.btnMixSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMixSearch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnMixSearch.Location = new System.Drawing.Point(424, 94);
            this.btnMixSearch.Name = "btnMixSearch";
            this.btnMixSearch.Size = new System.Drawing.Size(86, 23);
            this.btnMixSearch.TabIndex = 13;
            this.btnMixSearch.Text = "Mix search";
            this.btnMixSearch.UseSelectable = true;
            this.btnMixSearch.Click += new System.EventHandler(this.btnMixSearch_Click);
            // 
            // btnGetMyPlaylists
            // 
            this.btnGetMyPlaylists.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnGetMyPlaylists.Location = new System.Drawing.Point(119, 94);
            this.btnGetMyPlaylists.Name = "btnGetMyPlaylists";
            this.btnGetMyPlaylists.Size = new System.Drawing.Size(110, 23);
            this.btnGetMyPlaylists.TabIndex = 12;
            this.btnGetMyPlaylists.Text = "Get my playlists";
            this.btnGetMyPlaylists.UseSelectable = true;
            this.btnGetMyPlaylists.Click += new System.EventHandler(this.btnGetMyPlaylists_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSearch.Location = new System.Drawing.Point(516, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxArtist
            // 
            this.txtBoxArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBoxArtist.CustomButton.Image = null;
            this.txtBoxArtist.CustomButton.Location = new System.Drawing.Point(454, 2);
            this.txtBoxArtist.CustomButton.Name = "";
            this.txtBoxArtist.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBoxArtist.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxArtist.CustomButton.TabIndex = 1;
            this.txtBoxArtist.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxArtist.CustomButton.UseSelectable = true;
            this.txtBoxArtist.CustomButton.Visible = false;
            this.txtBoxArtist.Lines = new string[0];
            this.txtBoxArtist.Location = new System.Drawing.Point(119, 54);
            this.txtBoxArtist.MaxLength = 32767;
            this.txtBoxArtist.Name = "txtBoxArtist";
            this.txtBoxArtist.PasswordChar = '\0';
            this.txtBoxArtist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxArtist.SelectedText = "";
            this.txtBoxArtist.SelectionLength = 0;
            this.txtBoxArtist.SelectionStart = 0;
            this.txtBoxArtist.ShortcutsEnabled = true;
            this.txtBoxArtist.Size = new System.Drawing.Size(472, 20);
            this.txtBoxArtist.TabIndex = 10;
            this.txtBoxArtist.UseSelectable = true;
            this.txtBoxArtist.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxArtist.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBoxTitle.CustomButton.Image = null;
            this.txtBoxTitle.CustomButton.Location = new System.Drawing.Point(454, 2);
            this.txtBoxTitle.CustomButton.Name = "";
            this.txtBoxTitle.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBoxTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxTitle.CustomButton.TabIndex = 1;
            this.txtBoxTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxTitle.CustomButton.UseSelectable = true;
            this.txtBoxTitle.CustomButton.Visible = false;
            this.txtBoxTitle.Lines = new string[0];
            this.txtBoxTitle.Location = new System.Drawing.Point(119, 13);
            this.txtBoxTitle.MaxLength = 32767;
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.PasswordChar = '\0';
            this.txtBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxTitle.SelectedText = "";
            this.txtBoxTitle.SelectionLength = 0;
            this.txtBoxTitle.SelectionStart = 0;
            this.txtBoxTitle.ShortcutsEnabled = true;
            this.txtBoxTitle.Size = new System.Drawing.Size(472, 20);
            this.txtBoxTitle.TabIndex = 9;
            this.txtBoxTitle.UseSelectable = true;
            this.txtBoxTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(6, 54);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(43, 19);
            this.lblArtist.TabIndex = 8;
            this.lblArtist.Text = "Artist:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 19);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title:";
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.listViewResult);
            this.tabPageResult.Controls.Add(this.pnlResultControlls);
            this.tabPageResult.HorizontalScrollbarBarColor = true;
            this.tabPageResult.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageResult.HorizontalScrollbarSize = 10;
            this.tabPageResult.Location = new System.Drawing.Point(4, 38);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(599, 342);
            this.tabPageResult.TabIndex = 2;
            this.tabPageResult.Text = "Result";
            this.tabPageResult.UseVisualStyleBackColor = true;
            this.tabPageResult.VerticalScrollbarBarColor = true;
            this.tabPageResult.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageResult.VerticalScrollbarSize = 10;
            // 
            // listViewResult
            // 
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.Location = new System.Drawing.Point(3, 31);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.ShowGroups = false;
            this.listViewResult.Size = new System.Drawing.Size(593, 308);
            this.listViewResult.SmallImageList = this.imgResultListCover;
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
            // imgResultListCover
            // 
            this.imgResultListCover.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgResultListCover.ImageSize = new System.Drawing.Size(64, 64);
            this.imgResultListCover.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlResultControlls
            // 
            this.pnlResultControlls.Controls.Add(this.btnAddDownload);
            this.pnlResultControlls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResultControlls.HorizontalScrollbarBarColor = true;
            this.pnlResultControlls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlResultControlls.HorizontalScrollbarSize = 10;
            this.pnlResultControlls.Location = new System.Drawing.Point(3, 3);
            this.pnlResultControlls.Name = "pnlResultControlls";
            this.pnlResultControlls.Size = new System.Drawing.Size(593, 28);
            this.pnlResultControlls.TabIndex = 1;
            this.pnlResultControlls.VerticalScrollbarBarColor = true;
            this.pnlResultControlls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlResultControlls.VerticalScrollbarSize = 10;
            // 
            // btnAddDownload
            // 
            this.btnAddDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDownload.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAddDownload.Location = new System.Drawing.Point(424, 3);
            this.btnAddDownload.Name = "btnAddDownload";
            this.btnAddDownload.Size = new System.Drawing.Size(164, 23);
            this.btnAddDownload.TabIndex = 0;
            this.btnAddDownload.Text = "Add to download";
            this.btnAddDownload.UseSelectable = true;
            this.btnAddDownload.Click += new System.EventHandler(this.btnAddDownload_Click);
            // 
            // tabPageDownload
            // 
            this.tabPageDownload.Controls.Add(this.listViewDownload);
            this.tabPageDownload.Controls.Add(this.pnlDownloadControls);
            this.tabPageDownload.HorizontalScrollbarBarColor = true;
            this.tabPageDownload.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageDownload.HorizontalScrollbarSize = 10;
            this.tabPageDownload.Location = new System.Drawing.Point(4, 38);
            this.tabPageDownload.Name = "tabPageDownload";
            this.tabPageDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDownload.Size = new System.Drawing.Size(599, 342);
            this.tabPageDownload.TabIndex = 1;
            this.tabPageDownload.Text = "Download";
            this.tabPageDownload.UseVisualStyleBackColor = true;
            this.tabPageDownload.VerticalScrollbarBarColor = true;
            this.tabPageDownload.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageDownload.VerticalScrollbarSize = 10;
            // 
            // listViewDownload
            // 
            this.listViewDownload.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderArtist,
            this.columnHeaderAlbum});
            this.listViewDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDownload.FullRowSelect = true;
            this.listViewDownload.Location = new System.Drawing.Point(3, 31);
            this.listViewDownload.Name = "listViewDownload";
            this.listViewDownload.ShowGroups = false;
            this.listViewDownload.Size = new System.Drawing.Size(593, 308);
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
            // imgDownloadListCover
            // 
            this.imgDownloadListCover.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgDownloadListCover.ImageSize = new System.Drawing.Size(64, 64);
            this.imgDownloadListCover.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlDownloadControls
            // 
            this.pnlDownloadControls.Controls.Add(this.btnRemoveDownload);
            this.pnlDownloadControls.Controls.Add(this.progressBarDownload);
            this.pnlDownloadControls.Controls.Add(this.btnDownload);
            this.pnlDownloadControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDownloadControls.HorizontalScrollbarBarColor = true;
            this.pnlDownloadControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDownloadControls.HorizontalScrollbarSize = 10;
            this.pnlDownloadControls.Location = new System.Drawing.Point(3, 3);
            this.pnlDownloadControls.Name = "pnlDownloadControls";
            this.pnlDownloadControls.Size = new System.Drawing.Size(593, 28);
            this.pnlDownloadControls.TabIndex = 1;
            this.pnlDownloadControls.VerticalScrollbarBarColor = true;
            this.pnlDownloadControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDownloadControls.VerticalScrollbarSize = 10;
            // 
            // btnRemoveDownload
            // 
            this.btnRemoveDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDownload.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRemoveDownload.Location = new System.Drawing.Point(398, 3);
            this.btnRemoveDownload.Name = "btnRemoveDownload";
            this.btnRemoveDownload.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveDownload.TabIndex = 2;
            this.btnRemoveDownload.Text = "Remove from list";
            this.btnRemoveDownload.UseSelectable = true;
            this.btnRemoveDownload.Click += new System.EventHandler(this.btnRemoveDownload_Click);
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarDownload.Enabled = false;
            this.progressBarDownload.Location = new System.Drawing.Point(0, 3);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(392, 23);
            this.progressBarDownload.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDownload.Location = new System.Drawing.Point(513, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseSelectable = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tabPagePlaylist
            // 
            this.tabPagePlaylist.Controls.Add(this.listViewPlaylist);
            this.tabPagePlaylist.Controls.Add(this.pnlPlaylistControls);
            this.tabPagePlaylist.HorizontalScrollbarBarColor = true;
            this.tabPagePlaylist.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagePlaylist.HorizontalScrollbarSize = 10;
            this.tabPagePlaylist.Location = new System.Drawing.Point(4, 38);
            this.tabPagePlaylist.Name = "tabPagePlaylist";
            this.tabPagePlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlaylist.Size = new System.Drawing.Size(599, 342);
            this.tabPagePlaylist.TabIndex = 3;
            this.tabPagePlaylist.Text = "Playlist";
            this.tabPagePlaylist.UseVisualStyleBackColor = true;
            this.tabPagePlaylist.VerticalScrollbarBarColor = true;
            this.tabPagePlaylist.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagePlaylist.VerticalScrollbarSize = 10;
            // 
            // listViewPlaylist
            // 
            this.listViewPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPlaylistTitle});
            this.listViewPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPlaylist.FullRowSelect = true;
            this.listViewPlaylist.Location = new System.Drawing.Point(3, 31);
            this.listViewPlaylist.MultiSelect = false;
            this.listViewPlaylist.Name = "listViewPlaylist";
            this.listViewPlaylist.ShowGroups = false;
            this.listViewPlaylist.Size = new System.Drawing.Size(593, 308);
            this.listViewPlaylist.TabIndex = 0;
            this.listViewPlaylist.UseCompatibleStateImageBehavior = false;
            this.listViewPlaylist.View = System.Windows.Forms.View.Details;
            this.listViewPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPlaylist_MouseDoubleClick);
            // 
            // columnHeaderPlaylistTitle
            // 
            this.columnHeaderPlaylistTitle.Text = "Title";
            // 
            // pnlPlaylistControls
            // 
            this.pnlPlaylistControls.Controls.Add(this.btnOpenPlaylist);
            this.pnlPlaylistControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlaylistControls.HorizontalScrollbarBarColor = true;
            this.pnlPlaylistControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPlaylistControls.HorizontalScrollbarSize = 10;
            this.pnlPlaylistControls.Location = new System.Drawing.Point(3, 3);
            this.pnlPlaylistControls.Name = "pnlPlaylistControls";
            this.pnlPlaylistControls.Size = new System.Drawing.Size(593, 28);
            this.pnlPlaylistControls.TabIndex = 1;
            this.pnlPlaylistControls.VerticalScrollbarBarColor = true;
            this.pnlPlaylistControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPlaylistControls.VerticalScrollbarSize = 10;
            // 
            // btnOpenPlaylist
            // 
            this.btnOpenPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPlaylist.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnOpenPlaylist.Location = new System.Drawing.Point(509, 3);
            this.btnOpenPlaylist.Name = "btnOpenPlaylist";
            this.btnOpenPlaylist.Size = new System.Drawing.Size(79, 23);
            this.btnOpenPlaylist.TabIndex = 0;
            this.btnOpenPlaylist.Text = "Open";
            this.btnOpenPlaylist.UseSelectable = true;
            this.btnOpenPlaylist.Click += new System.EventHandler(this.btnOpenPlaylist_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(0, 5);
            this.picBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(64, 64);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 3;
            this.picBoxLogo.TabStop = false;
            // 
            // controlPanelToolStripMenuItem
            // 
            this.controlPanelToolStripMenuItem.Name = "controlPanelToolStripMenuItem";
            this.controlPanelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.controlPanelToolStripMenuItem.Text = "Control Panel";
            this.controlPanelToolStripMenuItem.Click += new System.EventHandler(this.controlPanelToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 488);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.tabControlSR);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "FrmMain";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "GMusicProxyGui";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabControlSR.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageResult.ResumeLayout(false);
            this.pnlResultControlls.ResumeLayout(false);
            this.tabPageDownload.ResumeLayout(false);
            this.pnlDownloadControls.ResumeLayout(false);
            this.tabPagePlaylist.ResumeLayout(false);
            this.pnlPlaylistControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl tabControlSR;
        private MetroFramework.Controls.MetroTabPage tabPageSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtBoxArtist;
        private MetroFramework.Controls.MetroTextBox txtBoxTitle;
        private MetroFramework.Controls.MetroLabel lblArtist;
        private MetroFramework.Controls.MetroLabel lblTitle;
        private MetroFramework.Controls.MetroTabPage tabPageDownload;
        private System.Windows.Forms.ListView listViewDownload;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderAlbum;
        private System.Windows.Forms.ColumnHeader columnHeaderArtist;
        private System.Windows.Forms.ImageList imgDownloadListCover;
        private MetroFramework.Controls.MetroPanel pnlDownloadControls;
        private MetroFramework.Controls.MetroButton btnDownload;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleArtistToolStripMenuItem;
        private MetroFramework.Controls.MetroProgressBar progressBarDownload;
        private MetroFramework.Controls.MetroTabPage tabPageResult;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroPanel pnlResultControlls;
        private MetroFramework.Controls.MetroButton btnAddDownload;
        private System.Windows.Forms.ImageList imgResultListCover;
        private MetroFramework.Controls.MetroButton btnRemoveDownload;
        private MetroFramework.Controls.MetroButton btnGetMyPlaylists;
        private MetroFramework.Controls.MetroTabPage tabPagePlaylist;
        private System.Windows.Forms.ListView listViewPlaylist;
        private System.Windows.Forms.ColumnHeader columnHeaderPlaylistTitle;
        private MetroFramework.Controls.MetroPanel pnlPlaylistControls;
        private MetroFramework.Controls.MetroButton btnOpenPlaylist;
        private MetroFramework.Controls.MetroButton btnMixSearch;
        private MetroFramework.Controls.MetroButton btnGetMyStations;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
    }
}

