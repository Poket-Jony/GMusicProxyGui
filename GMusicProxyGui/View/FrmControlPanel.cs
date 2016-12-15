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
using System.Diagnostics;

namespace GMusicProxyGui.View
{
    public partial class FrmControlPanel : MetroFramework.Forms.MetroForm
    {
        private string BashPath { get; set; } = Path.Combine(Environment.SystemDirectory, "bash.exe");
        private string StatusFile { get; set; } = Path.Combine(Application.StartupPath, "gmusicproxy-master", "process.txt");
        private bool ServerStatus { get; set; }

        public FrmControlPanel()
        {
            InitializeComponent();
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            if (Directory.Exists(Path.Combine(Application.StartupPath, "gmusicproxy-master")))
            {
                if (File.Exists(StatusFile))
                {
                    ServerStatus = true;
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    lblStatus.Text = "Server startet";
                }
                else
                {
                    ServerStatus = false;
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    lblStatus.Text = "Server stopped";
                }
            }
            else
            {
                ServerStatus = false;
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                lblStatus.Text = "Server not installed";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!File.Exists(StatusFile))
            {
                File.WriteAllText(StatusFile, "GMusicProxy", Encoding.UTF8);
                Process.Start(BashPath);
                Process.Start(BashPath, "-c \"cd gmusicproxy-master; ./start.sh\"").WaitForExit();
                RefreshStatus();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (File.Exists(StatusFile))
            {
                File.Delete(StatusFile);
                Process.Start(BashPath, "-c \"killall GMusicProxy\"").WaitForExit();
                RefreshStatus();
            }
        }
    }
}
