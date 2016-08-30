using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMusicProxyGui
{
    public partial class FrmInstaller : MetroFramework.Forms.MetroForm
    {
        public FrmInstaller()
        {
            InitializeComponent();
        }

        private bool DownloadPython()
        {
            return false;
        }

        private bool InstallPython()
        {
            return false;
        }

        private bool DownloadProxy()
        {
            return false;
        }

        private bool ExtractProxy()
        {
            return false;
        }

        private bool InstallRequirements()
        {
            return false;
        }

        private bool ConfigureProxy()
        {
            return false;
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if (DownloadPython() && InstallPython() && DownloadProxy() && ExtractProxy() && InstallRequirements() && ConfigureProxy())
            {
                MetroFramework.MetroMessageBox.Show(this, "Installation is finished", "Install success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
