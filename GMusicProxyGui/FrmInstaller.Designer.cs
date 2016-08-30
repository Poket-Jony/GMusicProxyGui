namespace GMusicProxyGui
{
    partial class FrmInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstaller));
            this.lblDownloadPython = new MetroFramework.Controls.MetroLabel();
            this.lblInstallPython = new MetroFramework.Controls.MetroLabel();
            this.lblDownloadProxy = new MetroFramework.Controls.MetroLabel();
            this.lblExtractProxy = new MetroFramework.Controls.MetroLabel();
            this.lblInstallRequirements = new MetroFramework.Controls.MetroLabel();
            this.lblConfigureProxy = new MetroFramework.Controls.MetroLabel();
            this.btnInstall = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblDownloadPython
            // 
            this.lblDownloadPython.AutoSize = true;
            this.lblDownloadPython.Location = new System.Drawing.Point(23, 60);
            this.lblDownloadPython.Name = "lblDownloadPython";
            this.lblDownloadPython.Size = new System.Drawing.Size(124, 19);
            this.lblDownloadPython.TabIndex = 0;
            this.lblDownloadPython.Text = "1. Download Python";
            // 
            // lblInstallPython
            // 
            this.lblInstallPython.AutoSize = true;
            this.lblInstallPython.Location = new System.Drawing.Point(23, 79);
            this.lblInstallPython.Name = "lblInstallPython";
            this.lblInstallPython.Size = new System.Drawing.Size(99, 19);
            this.lblInstallPython.TabIndex = 1;
            this.lblInstallPython.Text = "2. Install Python";
            // 
            // lblDownloadProxy
            // 
            this.lblDownloadProxy.AutoSize = true;
            this.lblDownloadProxy.Location = new System.Drawing.Point(23, 98);
            this.lblDownloadProxy.Name = "lblDownloadProxy";
            this.lblDownloadProxy.Size = new System.Drawing.Size(161, 19);
            this.lblDownloadProxy.TabIndex = 2;
            this.lblDownloadProxy.Text = "3. Download GMusicProxy";
            // 
            // lblExtractProxy
            // 
            this.lblExtractProxy.AutoSize = true;
            this.lblExtractProxy.Location = new System.Drawing.Point(23, 117);
            this.lblExtractProxy.Name = "lblExtractProxy";
            this.lblExtractProxy.Size = new System.Drawing.Size(141, 19);
            this.lblExtractProxy.TabIndex = 3;
            this.lblExtractProxy.Text = "4. Extract GMusicProxy";
            // 
            // lblInstallRequirements
            // 
            this.lblInstallRequirements.AutoSize = true;
            this.lblInstallRequirements.Location = new System.Drawing.Point(23, 136);
            this.lblInstallRequirements.Name = "lblInstallRequirements";
            this.lblInstallRequirements.Size = new System.Drawing.Size(215, 19);
            this.lblInstallRequirements.TabIndex = 4;
            this.lblInstallRequirements.Text = "5. Install GMusicProxy requirements";
            // 
            // lblConfigureProxy
            // 
            this.lblConfigureProxy.AutoSize = true;
            this.lblConfigureProxy.Location = new System.Drawing.Point(23, 155);
            this.lblConfigureProxy.Name = "lblConfigureProxy";
            this.lblConfigureProxy.Size = new System.Drawing.Size(160, 19);
            this.lblConfigureProxy.TabIndex = 5;
            this.lblConfigureProxy.Text = "6. Configure GMusicProxy";
            // 
            // btnInstall
            // 
            this.btnInstall.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnInstall.Location = new System.Drawing.Point(227, 212);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 6;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseSelectable = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // FrmInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 258);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.lblConfigureProxy);
            this.Controls.Add(this.lblInstallRequirements);
            this.Controls.Add(this.lblExtractProxy);
            this.Controls.Add(this.lblDownloadProxy);
            this.Controls.Add(this.lblInstallPython);
            this.Controls.Add(this.lblDownloadPython);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInstaller";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDownloadPython;
        private MetroFramework.Controls.MetroLabel lblInstallPython;
        private MetroFramework.Controls.MetroLabel lblDownloadProxy;
        private MetroFramework.Controls.MetroLabel lblExtractProxy;
        private MetroFramework.Controls.MetroLabel lblInstallRequirements;
        private MetroFramework.Controls.MetroLabel lblConfigureProxy;
        private MetroFramework.Controls.MetroButton btnInstall;
    }
}