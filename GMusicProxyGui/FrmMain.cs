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

namespace GMusicProxyGui
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            new FrmSettings().CheckFirstStartup();
        }

        private void SearchSong(string title, string artist)
        {
            if (!downloadAvaible)
                return;
            ClearResultList();
            Cursor.Current = Cursors.WaitCursor;
            List<MusicEntry> musicEntrys = WebApi.Instance.GetMusicBySearch(title, artist, Properties.Settings.Default.resultCount);
            Cursor.Current = Cursors.Default;
            if (musicEntrys == null || musicEntrys.Count == 0)
                return;
            foreach (MusicEntry musicEntry in musicEntrys)
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
            string albumId = WebApi.Instance.GetIdBySearch(WebApi.SearchType.album, title, artist);
            Cursor.Current = Cursors.Default;
            if (string.IsNullOrEmpty(albumId))
                return;
            List<MusicEntry> musicEntrys = WebApi.Instance.GetAlbumById(albumId);
            foreach (MusicEntry musicEntry in musicEntrys)
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
            string artistId = WebApi.Instance.GetIdBySearch(WebApi.SearchType.artist, artist, artist);
            Cursor.Current = Cursors.Default;
            if (string.IsNullOrEmpty(artistId))
                return;
            List<MusicEntry> musicEntrys = WebApi.Instance.GetArtistTopTracksById(artistId, Properties.Settings.Default.resultCount);
            foreach (MusicEntry musicEntry in musicEntrys)
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
                MessageBox.Show(this, "Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ClearResultList()
        {
            listViewResult.Items.Clear();
            imgListCover.Images.Clear();
        }

        private void AddResultListItem(MusicEntry musicEntry)
        {
            ListViewItem item = new ListViewItem(musicEntry.Title);
            item.Tag = musicEntry;
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, musicEntry.Artist) { Tag = columnHeaderArtist });
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, musicEntry.Album) { Tag = columnHeaderAlbum });
            listViewResult.Items.Add(item);
            if(musicEntry.IsFileExists())
            {
                Bitmap img = musicEntry.GetCoverFromFile();
                if (img != null)
                {
                    imgListCover.Images.Add(musicEntry.ProxyId, img);
                    item.ImageKey = musicEntry.ProxyId;
                }
            }
        }

        private bool downloadAvaible = true;
        private async void DownloadListItems()
        {
            if (!downloadAvaible)
                return;
            if (listViewResult.SelectedItems.Count == 0)
                return;
            if (MessageBox.Show(this, "Would you download the items?", "Download", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                List<ListViewItem> downloadItems = new List<ListViewItem>();
                foreach (ListViewItem item in listViewResult.SelectedItems)
                {
                    MusicEntry musicEntry = (MusicEntry)item.Tag;
                    if (!musicEntry.IsFileExists())
                        downloadItems.Add(item);
                }
                downloadAvaible = false;
                progressBarDownload.Maximum = downloadItems.Count;
                progressBarDownload.Enabled = true;
                foreach (ListViewItem item in downloadItems)
                {
                    progressBarDownload.Value++;
                    MusicEntry musicEntry = (MusicEntry)item.Tag;
                    musicEntry.UpdateFilePath();
                    try
                    {
                        await WebApi.Instance.DownloadSong(musicEntry.ProxyPath, musicEntry.FilePath);
                        Bitmap img = musicEntry.GetCoverFromFile();
                        if (img != null)
                        {
                            imgListCover.Images.Add(musicEntry.ProxyId, img);
                            item.ImageKey = musicEntry.ProxyId;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(this, "Error at item " + progressBarDownload.Value + ":\n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                }
                progressBarDownload.Value = 0;
                progressBarDownload.Enabled = false;
                downloadAvaible = true;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSettings().ShowDialog(this);
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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadListItems();
        }

        private void listViewResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewResult.SelectedItems.Count == 0)
                return;
            ListViewHitTestInfo hit = listViewResult.HitTest(e.Location);
            if(hit != null && hit.Item != null && hit.SubItem != null)
            {
                if (hit.SubItem.Tag == columnHeaderAlbum)
                    SearchAlbum(hit.SubItem.Text, ((MusicEntry)hit.Item.Tag).Artist);
                else if (hit.SubItem.Tag == columnHeaderArtist)
                    SearchArtistTopTracks(((MusicEntry)hit.Item.Tag).Artist);
                else
                    DownloadListItems();
            }
        }

        private void SearchList(ListImporter import)
        {
            if (!downloadAvaible)
                return;
            ClearResultList();
            foreach (MusicEntry musicEntry in import.MusicList)
            {
                AddResultListItem(musicEntry);
            }
            listViewResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tabControlSR.SelectedTab = tabPageResult;
        }

        private void artistTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Syntax:\nArtist1 - Title1\nArtist2 - Title2\n...", "Syntax help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a list file to import:";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                SearchList(new ListImporter(dialog.FileName, ListImporter.ListType.ArtistAndTitle));
                Cursor.Current = Cursors.Default;
            }
        }

        private void titleArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Syntax:\nTitle1 - Artist1\nTitle2 - Artist2\n...", "Syntax help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a list file to import:";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                SearchList(new ListImporter(dialog.FileName, ListImporter.ListType.TitleAndArtist));
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
