using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GMusicProxyGui.Controller;
using GMusicProxyGui.Model;

namespace GMusicProxyGui.View
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
            ConfigController.CheckFirstStartup();
            Init();
        }

        private void Init()
        {
            tabControlSR.SelectedTab = tabPageSearch;
        }

        #region Search
        private void SearchSong(string title, string artist)
        {
            if (!downloadAvaible)
                return;
            ClearResultList();
            Cursor.Current = Cursors.WaitCursor;
            List<MusicEntryModel> musicEntrys = ProxyApiController.Instance.GetMusicBySearch(title, artist, ConfigController.ResultCount);
            Cursor.Current = Cursors.Default;
            if (musicEntrys == null || musicEntrys.Count == 0)
                return;
            foreach (MusicEntryModel musicEntry in musicEntrys)
            {
                AddResultListItem(musicEntry);
            }
            listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tabControlSR.SelectedTab = tabPageResult;
        }

        private void SearchAlbum(string title, string artist)
        {
            if (!downloadAvaible)
                return;
            ClearResultList();
            Cursor.Current = Cursors.WaitCursor;
            string albumId = ProxyApiController.Instance.GetIdBySearch(ProxyApiController.SearchType.album, title, artist);
            Cursor.Current = Cursors.Default;
            if (string.IsNullOrEmpty(albumId))
                return;
            List<MusicEntryModel> musicEntrys = ProxyApiController.Instance.GetAlbumById(albumId);
            foreach (MusicEntryModel musicEntry in musicEntrys)
            {
                AddResultListItem(musicEntry);
            }
            listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tabControlSR.SelectedTab = tabPageResult;
        }

        private void SearchArtistTopTracks(string artist)
        {
            if (!downloadAvaible)
                return;
            ClearResultList();
            Cursor.Current = Cursors.WaitCursor;
            string artistId = ProxyApiController.Instance.GetIdBySearch(ProxyApiController.SearchType.artist, artist, artist);
            Cursor.Current = Cursors.Default;
            if (string.IsNullOrEmpty(artistId))
                return;
            List<MusicEntryModel> musicEntrys = ProxyApiController.Instance.GetArtistTopTracksById(artistId, ConfigController.ResultCount);
            foreach (MusicEntryModel musicEntry in musicEntrys)
            {
                AddResultListItem(musicEntry);
            }
            listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tabControlSR.SelectedTab = tabPageResult;
        }

        private void GetMyPlaylists()
        {
            if (!downloadAvaible)
                return;
            ClearPlaylistList();
            Cursor.Current = Cursors.WaitCursor;
            List<PlaylistEntryModel> playlistEntrys = ProxyApiController.Instance.GetMyPlaylists();
            Cursor.Current = Cursors.Default;
            if (playlistEntrys == null || playlistEntrys.Count == 0)
                return;
            foreach (PlaylistEntryModel playlistEntry in playlistEntrys)
            {
                AddPlaylistListItem(playlistEntry);
            }
            listViewPlaylist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tabControlSR.SelectedTab = tabPagePlaylist;
        }

        private void GetMyStations()
        {
            if (!downloadAvaible)
                return;
            ClearPlaylistList();
            Cursor.Current = Cursors.WaitCursor;
            List<PlaylistEntryModel> playlistEntrys = ProxyApiController.Instance.GetMyStations();
            Cursor.Current = Cursors.Default;
            if (playlistEntrys == null || playlistEntrys.Count == 0)
                return;
            foreach (PlaylistEntryModel playlistEntry in playlistEntrys)
            {
                AddPlaylistListItem(playlistEntry);
            }
            listViewPlaylist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tabControlSR.SelectedTab = tabPagePlaylist;
        }

        private void OpenPlaylist(PlaylistEntryModel playlistEntry)
        {
            if (!downloadAvaible)
                return;
            ClearResultList();
            Cursor.Current = Cursors.WaitCursor;
            List<MusicEntryModel> musicEntrys = ProxyApiController.Instance.GetMusicByPlaylist(playlistEntry);
            Cursor.Current = Cursors.Default;
            if (musicEntrys == null || musicEntrys.Count == 0)
                return;
            foreach (MusicEntryModel musicEntry in musicEntrys)
            {
                AddResultListItem(musicEntry);
            }
            listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tabControlSR.SelectedTab = tabPageResult;
        }

        private void SearchMix(string title, string artist)
        {
            if (!downloadAvaible)
                return;
            ClearResultList();
            Cursor.Current = Cursors.WaitCursor;
            List<MusicEntryModel> musicEntrys = ProxyApiController.Instance.GetMusicByMixSearch(title, artist, ConfigController.ResultCount);
            Cursor.Current = Cursors.Default;
            if (musicEntrys == null || musicEntrys.Count == 0)
                return;
            foreach (MusicEntryModel musicEntry in musicEntrys)
            {
                AddResultListItem(musicEntry);
            }
            listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tabControlSR.SelectedTab = tabPageResult;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxTitle.Text) || !string.IsNullOrEmpty(txtBoxArtist.Text))
                SearchSong(txtBoxTitle.Text, txtBoxArtist.Text);
            else
                MetroFramework.MetroMessageBox.Show(this, "Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region List
        private void ClearResultList()
        {
            listViewResult.Items.Clear();
            imgResultListCover.Images.Clear();
        }

        private void ClearDownloadList()
        {
            listViewDownload.Items.Clear();
            imgDownloadListCover.Images.Clear();
        }

        private void ClearPlaylistList()
        {
            listViewPlaylist.Items.Clear();
        }

        private void RemoveFromDownloadList(MusicEntryModel musicEntry)
        {
            if (musicEntry != null)
            {
                listViewDownload.Items.RemoveByKey(musicEntry.ProxyId);
                imgDownloadListCover.Images.RemoveByKey(musicEntry.ProxyId);
            }
        }

        private void AddResultListItem(MusicEntryModel musicEntry)
        {
            if (listViewResult.Items.Find(musicEntry.ProxyId, false).Length != 0)
                return;
            ListViewItem item = new ListViewItem(musicEntry.Title);
            item.Name = musicEntry.ProxyId;
            item.Tag = musicEntry;
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, musicEntry.Artist) { Tag = columnHeaderArtist });
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, musicEntry.Album) { Tag = columnHeaderAlbum });
            listViewResult.Items.Add(item);
            if(musicEntry.IsFileExists())
            {
                Bitmap img = musicEntry.GetCoverFromFile();
                if (img != null)
                {
                    imgResultListCover.Images.Add(musicEntry.ProxyId, img);
                    item.ImageKey = musicEntry.ProxyId;
                }
            }
        }
        private void AddPlaylistListItem(PlaylistEntryModel playlistEntry)
        {
            if (listViewPlaylist.Items.Find(playlistEntry.ProxyId, false).Length != 0)
                return;
            ListViewItem item = new ListViewItem(playlistEntry.Title);
            item.Name = playlistEntry.ProxyId;
            item.Tag = playlistEntry;
            listViewPlaylist.Items.Add(item);
        }

        private void AddDownloadListItem(MusicEntryModel musicEntry)
        {
            if (listViewDownload.Items.Find(musicEntry.ProxyId, false).Length != 0)
                return;
            ListViewItem item = new ListViewItem(musicEntry.Title);
            item.Name = musicEntry.ProxyId;
            item.Tag = musicEntry;
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, musicEntry.Artist) { Tag = columnHeaderArtist });
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, musicEntry.Album) { Tag = columnHeaderAlbum });
            listViewDownload.Items.Add(item);
            if (musicEntry.IsFileExists())
            {
                Bitmap img = musicEntry.GetCoverFromFile();
                if (img != null)
                {
                    imgDownloadListCover.Images.Add(musicEntry.ProxyId, img);
                    item.ImageKey = musicEntry.ProxyId;
                }
            }
        }

        private bool downloadAvaible = true;
        private async void DownloadListItems()
        {
            if (!downloadAvaible)
                return;
            if (listViewDownload.SelectedItems.Count == 0)
                return;
            if (MetroFramework.MetroMessageBox.Show(this, "Would you download the items?", "Download", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                List<ListViewItem> downloadItems = new List<ListViewItem>();
                foreach (ListViewItem item in listViewDownload.SelectedItems)
                {
                    MusicEntryModel musicEntry = (MusicEntryModel)item.Tag;
                    if (!musicEntry.IsFileExists())
                        downloadItems.Add(item);
                }
                downloadAvaible = false;
                progressBarDownload.Maximum = downloadItems.Count;
                progressBarDownload.Enabled = true;
                foreach (ListViewItem item in downloadItems)
                {
                    progressBarDownload.Value++;
                    MusicEntryModel musicEntry = (MusicEntryModel)item.Tag;
                    musicEntry.UpdateFilePath();
                    start_download:
                    try
                    {
                        await ProxyApiController.Instance.DownloadSong(musicEntry.ProxyPath, musicEntry.FilePath);
                        Bitmap img = musicEntry.GetCoverFromFile();
                        if (img != null)
                        {
                            imgDownloadListCover.Images.Add(musicEntry.ProxyId, img);
                            item.ImageKey = musicEntry.ProxyId;
                        }
                    }
                    catch (Exception e)
                    {
                        try
                        {
                            File.Delete(musicEntry.FilePath);
                        }
                        catch { }
                        if (!ConfigController.IgnoreErrors)
                        {
                            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Error at item " + progressBarDownload.Value + ":\n" + e.ToString(), "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                            if (dialogResult == DialogResult.Retry)
                                goto start_download;
                            else if (dialogResult == DialogResult.Ignore)
                                continue;
                            else
                                break;
                        }
                        else
                            continue;
                    }
                }
                progressBarDownload.Value = 0;
                progressBarDownload.Enabled = false;
                downloadAvaible = true;
            }
        }

        private void AddDownloadListItemsFromResult()
        {
            if (!downloadAvaible)
                return;
            if (listViewResult.SelectedItems.Count == 0)
                return;
            if (MetroFramework.MetroMessageBox.Show(this, "Would you add the items to the download list?", "Download list", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach (ListViewItem item in listViewResult.SelectedItems)
                {
                    MusicEntryModel musicEntry = (MusicEntryModel)item.Tag;
                    AddDownloadListItem(musicEntry);
                }
                listViewDownload.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void RemoveDownloadListItemsFromSelection()
        {
            if (!downloadAvaible)
                return;
            if (listViewDownload.SelectedItems.Count == 0)
                return;
            if (MetroFramework.MetroMessageBox.Show(this, "Would you remove the items from the download list?", "Download list", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach (ListViewItem item in listViewDownload.SelectedItems)
                {
                    MusicEntryModel musicEntry = (MusicEntryModel)item.Tag;
                    RemoveFromDownloadList(musicEntry);
                }
                listViewDownload.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void OpenPlaylistFromSelection()
        {
            if (!downloadAvaible)
                return;
            if (listViewPlaylist.SelectedItems.Count == 0)
                return;

            PlaylistEntryModel playlistEntry = (PlaylistEntryModel)listViewPlaylist.SelectedItems[0].Tag;
            OpenPlaylist(playlistEntry);
            listViewPlaylist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSettings().ShowDialog(this);
        }

        private void listViewDownload_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                listViewDownload.MultiSelect = true;
                foreach (ListViewItem item in listViewDownload.Items)
                {
                    item.Selected = true;
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadListItems();
        }

        private void listViewDownload_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewDownload.SelectedItems.Count == 0)
                return;
            ListViewHitTestInfo hit = listViewDownload.HitTest(e.Location);
            if(hit != null && hit.Item != null && hit.SubItem != null)
            {
                if (hit.SubItem.Tag == columnHeaderAlbum)
                    SearchAlbum(hit.SubItem.Text, ((MusicEntryModel)hit.Item.Tag).Artist);
                else if (hit.SubItem.Tag == columnHeaderArtist)
                    SearchArtistTopTracks(((MusicEntryModel)hit.Item.Tag).Artist);
                else
                    DownloadListItems();
            }
        }

        private void SearchList(ListImportController import)
        {
            if (!downloadAvaible)
                return;
            ClearResultList();
            foreach (MusicEntryModel musicEntry in import.MusicList)
            {
                AddResultListItem(musicEntry);
            }
            listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tabControlSR.SelectedTab = tabPageResult;
        }

        private void listViewResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewResult.SelectedItems.Count == 0)
                return;
            ListViewHitTestInfo hit = listViewResult.HitTest(e.Location);
            if (hit != null && hit.Item != null && hit.SubItem != null)
            {
                if (hit.SubItem.Tag == columnHeaderAlbum)
                    SearchAlbum(hit.SubItem.Text, ((MusicEntryModel)hit.Item.Tag).Artist);
                else if (hit.SubItem.Tag == columnHeaderArtist)
                    SearchArtistTopTracks(((MusicEntryModel)hit.Item.Tag).Artist);
                else
                    AddDownloadListItemsFromResult();
            }
        }

        private void listViewResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                listViewResult.MultiSelect = true;
                foreach (ListViewItem item in listViewResult.Items)
                {
                    item.Selected = true;
                }
            }
        }

        private void btnAddDownload_Click(object sender, EventArgs e)
        {
            AddDownloadListItemsFromResult();
        }

        private void btnRemoveDownload_Click(object sender, EventArgs e)
        {
            RemoveDownloadListItemsFromSelection();
        }

        private void btnGetMyPlaylists_Click(object sender, EventArgs e)
        {
            GetMyPlaylists();
        }

        private void listViewPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewPlaylist.SelectedItems.Count == 0)
                return;
            ListViewHitTestInfo hit = listViewPlaylist.HitTest(e.Location);
            if (hit != null && hit.Item != null && hit.SubItem != null)
            {
                OpenPlaylistFromSelection();
            }
        }

        private void btnOpenPlaylist_Click(object sender, EventArgs e)
        {
            OpenPlaylistFromSelection();
        }

        private void btnMixSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxTitle.Text) || !string.IsNullOrEmpty(txtBoxArtist.Text))
                SearchMix(txtBoxTitle.Text, txtBoxArtist.Text);
            else
                MetroFramework.MetroMessageBox.Show(this, "Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnGetMyStations_Click(object sender, EventArgs e)
        {
            GetMyStations();
        }
        #endregion

        #region Menu
        private void artistTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Syntax:\nArtist1 - Title1\nArtist2 - Title2\n...", "Syntax help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a list file to import:";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                SearchList(new ListImportController(dialog.FileName, ListImportController.ListType.ArtistAndTitle));
                Cursor.Current = Cursors.Default;
            }
        }

        private void titleArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Syntax:\nTitle1 - Artist1\nTitle2 - Artist2\n...", "Syntax help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a list file to import:";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                SearchList(new ListImportController(dialog.FileName, ListImportController.ListType.TitleAndArtist));
                Cursor.Current = Cursors.Default;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = string.Format("Version: {0}\nAuthor: Jonas Plamann\nGitHub: https://github.com/Poket-Jony/GMusicProxyGui\nThis software only communicates with the GMusicProxy and not directly with any Google-API.", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            MetroFramework.MetroMessageBox.Show(this, msg, "About", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void installerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmInstaller().ShowDialog(this);
        }

        private void controlPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmControlPanel().ShowDialog(this);
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConfigInput().ShowDialog(this);
        }
        #endregion

    }
}
