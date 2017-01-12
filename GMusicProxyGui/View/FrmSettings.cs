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

namespace GMusicProxyGui.View
{
    public partial class FrmSettings : MetroFramework.Forms.MetroForm
    {
        public FrmSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            txtBoxMusicPath.Text = ConfigController.MusicPath;
            txtBoxProxyUrl.Text = ConfigController.ProxyUrl;
            numMusicCount.Value = ConfigController.ResultCount;
            chkBoxIgnoreErrors.Checked = ConfigController.IgnoreErrors;
            trackBarVolume.Value = ConfigController.MusicVolume;
        }

        private void SaveSettings()
        {
            if (!string.IsNullOrEmpty(txtBoxMusicPath.Text) && !string.IsNullOrEmpty(txtBoxProxyUrl.Text))
            {
                ConfigController.MusicPath = txtBoxMusicPath.Text;
                CreateMusicPath();
                ConfigController.ProxyUrl = txtBoxProxyUrl.Text;
                ConfigController.ResultCount = (int)numMusicCount.Value;
                ConfigController.IgnoreErrors = chkBoxIgnoreErrors.Checked;
                ConfigController.MusicVolume = trackBarVolume.Value;
            }
        }

        private void CreateMusicPath()
        {
            if (string.IsNullOrEmpty(ConfigController.MusicPath))
                return;
            if (!Directory.Exists(ConfigController.MusicPath))
                Directory.CreateDirectory(ConfigController.MusicPath);
        }

        private void btnToDefault_Click(object sender, EventArgs e)
        {
            ConfigController.ToDefault();
            CreateMusicPath();
            LoadSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxMusicPath.Text) || string.IsNullOrEmpty(txtBoxProxyUrl.Text))
            {
                MessageBox.Show(this, "Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SaveSettings();
            ProxyApiController.GetNewInstance();
            this.Close();
        }

        private void btnMusicPathSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the folder to save the music!";
            dialog.SelectedPath = string.IsNullOrEmpty(txtBoxMusicPath.Text) ? Application.StartupPath : txtBoxMusicPath.Text;
            if (dialog.ShowDialog(this) == DialogResult.OK)
                txtBoxMusicPath.Text = dialog.SelectedPath;
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            AudioController.Instance.WaveOut.Volume = (float)trackBarVolume.Value / 10;
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            AudioController.Instance.UpdateMusicVolume();
        }
    }
}
