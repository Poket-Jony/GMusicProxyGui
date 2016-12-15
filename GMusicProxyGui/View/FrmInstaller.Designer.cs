namespace GMusicProxyGui.View
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
            this.lblInstallOSRequirements = new MetroFramework.Controls.MetroLabel();
            this.lblDownloadProxy = new MetroFramework.Controls.MetroLabel();
            this.lblExtractProxy = new MetroFramework.Controls.MetroLabel();
            this.lblInstallRequirements = new MetroFramework.Controls.MetroLabel();
            this.lblConfigureProxy = new MetroFramework.Controls.MetroLabel();
            this.btnInstall = new MetroFramework.Controls.MetroButton();
            this.lblCheckOSRequirements = new MetroFramework.Controls.MetroLabel();
            this.btnInstallBash = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblInstallOSRequirements
            // 
            this.lblInstallOSRequirements.AutoSize = true;
            this.lblInstallOSRequirements.Location = new System.Drawing.Point(23, 79);
            this.lblInstallOSRequirements.Name = "lblInstallOSRequirements";
            this.lblInstallOSRequirements.Size = new System.Drawing.Size(158, 19);
            this.lblInstallOSRequirements.TabIndex = 0;
            this.lblInstallOSRequirements.Text = "2. Install OS requirements";
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
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnInstall.Location = new System.Drawing.Point(227, 212);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 6;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseSelectable = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // lblCheckOSRequirements
            // 
            this.lblCheckOSRequirements.AutoSize = true;
            this.lblCheckOSRequirements.Location = new System.Drawing.Point(23, 60);
            this.lblCheckOSRequirements.Name = "lblCheckOSRequirements";
            this.lblCheckOSRequirements.Size = new System.Drawing.Size(159, 19);
            this.lblCheckOSRequirements.TabIndex = 7;
            this.lblCheckOSRequirements.Text = "1. Check OS requirements";
            // 
            // btnInstallBash
            // 
            this.btnInstallBash.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnInstallBash.Location = new System.Drawing.Point(23, 212);
            this.btnInstallBash.Name = "btnInstallBash";
            this.btnInstallBash.Size = new System.Drawing.Size(88, 23);
            this.btnInstallBash.TabIndex = 8;
            this.btnInstallBash.Text = "Install bash";
            this.btnInstallBash.UseSelectable = true;
            this.btnInstallBash.Click += new System.EventHandler(this.btnInstallBash_Click);
            // 
            // FrmInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 258);
            this.Controls.Add(this.btnInstallBash);
            this.Controls.Add(this.lblCheckOSRequirements);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.lblConfigureProxy);
            this.Controls.Add(this.lblInstallRequirements);
            this.Controls.Add(this.lblExtractProxy);
            this.Controls.Add(this.lblDownloadProxy);
            this.Controls.Add(this.lblInstallOSRequirements);
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

        private MetroFramework.Controls.MetroLabel lblInstallOSRequirements;
        private MetroFramework.Controls.MetroLabel lblDownloadProxy;
        private MetroFramework.Controls.MetroLabel lblExtractProxy;
        private MetroFramework.Controls.MetroLabel lblInstallRequirements;
        private MetroFramework.Controls.MetroLabel lblConfigureProxy;
        private MetroFramework.Controls.MetroButton btnInstall;
        private MetroFramework.Controls.MetroLabel lblCheckOSRequirements;
        private MetroFramework.Controls.MetroButton btnInstallBash;
    }
}