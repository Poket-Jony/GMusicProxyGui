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
    public partial class FrmSettings : MetroFramework.Forms.MetroForm
    {
        public FrmSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            txtBoxMusicPath.Text = Properties.Settings.Default.musicPath;
            txtBoxProxyUrl.Text = Properties.Settings.Default.proxyUrl;
            numMusicCount.Value = Properties.Settings.Default.resultCount;
            chkBoxIgnoreErrors.Checked = Properties.Settings.Default.ignoreErrors;
        }

        private void ToDefault()
        {
            Properties.Settings.Default.musicPath = Application.StartupPath;
            Properties.Settings.Default.proxyUrl = "http://localhost:9999/";
            Properties.Settings.Default.resultCount = 20;
            Properties.Settings.Default.ignoreErrors = false;
            Properties.Settings.Default.Save();
            LoadSettings();
        }

        private void SaveSettings()
        {
            if (!string.IsNullOrEmpty(txtBoxMusicPath.Text) && !string.IsNullOrEmpty(txtBoxProxyUrl.Text))
            {
                Properties.Settings.Default.musicPath = txtBoxMusicPath.Text;
                Properties.Settings.Default.proxyUrl = txtBoxProxyUrl.Text;
                Properties.Settings.Default.resultCount = (int)numMusicCount.Value;
                Properties.Settings.Default.ignoreErrors = chkBoxIgnoreErrors.Checked;
                Properties.Settings.Default.Save();
            }
        }

        public bool CheckFirstStartup()
        {
            if(string.IsNullOrEmpty(Properties.Settings.Default.musicPath))
            {
                ToDefault();
                return true;
            }
            return false;
        }

        private void btnToDefault_Click(object sender, EventArgs e)
        {
            ToDefault();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxMusicPath.Text) || string.IsNullOrEmpty(txtBoxProxyUrl.Text))
            {
                MessageBox.Show(this, "Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SaveSettings();
            WebApi.GetNewInstance();
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
    }
}
