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
using System.Threading;

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
            List<MusicEntry> musicEntrys = WebApi.Instance.GetMusicBySearch(title, artist);
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
            string albumId = WebApi.Instance.GetIdBySearch(WebApi.SearchType.album, title, artist);
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
            string artistId = WebApi.Instance.GetIdBySearch(WebApi.SearchType.artist, artist, artist);
            if (string.IsNullOrEmpty(artistId))
                return;
            List<MusicEntry> musicEntrys = WebApi.Instance.GetArtistTopTracksById(artistId);
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
                    catch (OperationCanceledException)
                    {
                        return;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(this, "Error:\n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
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
    }
}
