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
    public partial class FrmConfigInput : MetroFramework.Forms.MetroForm
    {
        private string ConfigFile { get; set; } = Path.Combine(Application.StartupPath, "gmusicproxy-master", "gmusicproxy.cfg");

        public FrmConfigInput()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string config = string.Format("email = {0}\npassword = {1}\ndevice-id = {2}", txtBoxEmail.Text, txtBoxPassword.Text, txtBoxDeviceId.Text);
            File.WriteAllText(ConfigFile, config, Encoding.ASCII);
            MetroFramework.MetroMessageBox.Show(this, "Configuration successfully saved", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
