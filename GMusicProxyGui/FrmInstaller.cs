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

namespace GMusicProxyGui
{
    public partial class FrmInstaller : MetroFramework.Forms.MetroForm
    {
        private string BashPath { get; set; } = Path.Combine(Environment.SystemDirectory, "bash.exe");

        public FrmInstaller()
        {
            InitializeComponent();
        }

        private bool CheckOSRequirements()
        {
            lblCheckOSRequirements.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            lblCheckOSRequirements.AutoSize = false;
            lblCheckOSRequirements.AutoSize = true;

            bool ret = false;
            if (Environment.OSVersion.Version.Major >= 6 && Environment.OSVersion.Version.Minor >= 2) //Windows 8, 8.1, 10
            {
                if(File.Exists(BashPath))
                    ret = true;
                else
                    MetroFramework.MetroMessageBox.Show(this, "Please activate the bash feature in Windows 10\n\nhttps://msdn.microsoft.com/en-us/commandline/wsl/install_guide", "Install failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Your need Windows 10 to use the installer", "Install failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            lblCheckOSRequirements.FontWeight = MetroFramework.MetroLabelWeight.Light;
            return ret;
        }

        private bool InstallOSRequirements()
        {
            lblInstallOSRequirements.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            lblInstallOSRequirements.AutoSize = false;
            lblInstallOSRequirements.AutoSize = true;

            Process.Start(BashPath, "-c \"sudo apt-get install build-essential python2.7-dev libffi-dev libssl-dev python-pip unzip\"").WaitForExit();

            lblInstallOSRequirements.FontWeight = MetroFramework.MetroLabelWeight.Light;
            return true;
        }

        private bool DownloadProxy()
        {
            lblDownloadProxy.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            lblDownloadProxy.AutoSize = false;
            lblDownloadProxy.AutoSize = true;

            if (File.Exists(Path.Combine(Application.StartupPath, "master.zip")))
                File.Delete(Path.Combine(Application.StartupPath, "master.zip"));

            Process.Start(BashPath, "-c \"wget https://github.com/diraimondo/gmusicproxy/archive/master.zip\"").WaitForExit();

            lblDownloadProxy.FontWeight = MetroFramework.MetroLabelWeight.Light;
            return true;
        }

        private bool ExtractProxy()
        {
            lblExtractProxy.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            lblExtractProxy.AutoSize = false;
            lblExtractProxy.AutoSize = true;

            if (Directory.Exists(Path.Combine(Application.StartupPath, "gmusicproxy-master")))
                Directory.Delete(Path.Combine(Application.StartupPath, "gmusicproxy-master"), true);

            Process.Start(BashPath, "-c \"unzip master.zip\"").WaitForExit();

            lblExtractProxy.FontWeight = MetroFramework.MetroLabelWeight.Light;
            return true;
        }

        private bool InstallRequirements()
        {
            lblInstallRequirements.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            lblInstallRequirements.AutoSize = false;
            lblInstallRequirements.AutoSize = true;

            Process.Start(BashPath, "-c \"cd gmusicproxy-master; sudo pip install -r requirements.txt\"").WaitForExit();

            lblInstallRequirements.FontWeight = MetroFramework.MetroLabelWeight.Light;
            return true;
        }

        private bool ConfigureProxy()
        {
            lblConfigureProxy.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            lblConfigureProxy.AutoSize = false;
            lblConfigureProxy.AutoSize = true;

            File.WriteAllText(Path.Combine(Application.StartupPath, "gmusicproxy-master", "start.sh"), "#!/bin/bash\nGMusicProxy -c gmusicproxy.cfg --host 172.0.0.1 --extended-m3u --daemon\necho \"Started!\"", Encoding.ASCII);
            Process.Start(BashPath, "-c \"cd gmusicproxy-master; chmod 777 start.sh\"").WaitForExit();
            new FrmConfigInput().ShowDialog(this);

            lblConfigureProxy.FontWeight = MetroFramework.MetroLabelWeight.Light;
            return true;
        }

        private bool InstallBash()
        {
            Process.Start(Path.Combine(Environment.SystemDirectory, "LxRun.exe"), "/install /y").WaitForExit();
            return true;
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to install the GMusicProxy Server?", "Install", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (CheckOSRequirements() && InstallOSRequirements() && DownloadProxy() && ExtractProxy() && InstallRequirements() && ConfigureProxy())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Installation is finished", "Install success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
        }

        private void btnInstallBash_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to install the Windows 10 bash?", "Install bash", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (CheckOSRequirements() && InstallBash())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Bash installation is finished", "Bash install success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
