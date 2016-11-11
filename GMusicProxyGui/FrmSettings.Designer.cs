namespace GMusicProxyGui
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.lblMusicPath = new MetroFramework.Controls.MetroLabel();
            this.txtBoxMusicPath = new MetroFramework.Controls.MetroTextBox();
            this.btnMusicPathSelect = new MetroFramework.Controls.MetroButton();
            this.lblProxyUrl = new MetroFramework.Controls.MetroLabel();
            this.txtBoxProxyUrl = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnToDefault = new MetroFramework.Controls.MetroButton();
            this.lblMusicCount = new MetroFramework.Controls.MetroLabel();
            this.numMusicCount = new System.Windows.Forms.NumericUpDown();
            this.chkBoxIgnoreErrors = new MetroFramework.Controls.MetroCheckBox();
            this.lblIgnoreErrors = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numMusicCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusicPath
            // 
            this.lblMusicPath.AutoSize = true;
            this.lblMusicPath.Location = new System.Drawing.Point(23, 77);
            this.lblMusicPath.Name = "lblMusicPath";
            this.lblMusicPath.Size = new System.Drawing.Size(74, 19);
            this.lblMusicPath.TabIndex = 0;
            this.lblMusicPath.Text = "Music Path:";
            // 
            // txtBoxMusicPath
            // 
            // 
            // 
            // 
            this.txtBoxMusicPath.CustomButton.Image = null;
            this.txtBoxMusicPath.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtBoxMusicPath.CustomButton.Name = "";
            this.txtBoxMusicPath.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBoxMusicPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxMusicPath.CustomButton.TabIndex = 1;
            this.txtBoxMusicPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxMusicPath.CustomButton.UseSelectable = true;
            this.txtBoxMusicPath.CustomButton.Visible = false;
            this.txtBoxMusicPath.Lines = new string[0];
            this.txtBoxMusicPath.Location = new System.Drawing.Point(148, 74);
            this.txtBoxMusicPath.MaxLength = 32767;
            this.txtBoxMusicPath.Name = "txtBoxMusicPath";
            this.txtBoxMusicPath.PasswordChar = '\0';
            this.txtBoxMusicPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxMusicPath.SelectedText = "";
            this.txtBoxMusicPath.SelectionLength = 0;
            this.txtBoxMusicPath.SelectionStart = 0;
            this.txtBoxMusicPath.ShortcutsEnabled = true;
            this.txtBoxMusicPath.Size = new System.Drawing.Size(189, 20);
            this.txtBoxMusicPath.TabIndex = 1;
            this.txtBoxMusicPath.UseSelectable = true;
            this.txtBoxMusicPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxMusicPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnMusicPathSelect
            // 
            this.btnMusicPathSelect.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnMusicPathSelect.Location = new System.Drawing.Point(343, 72);
            this.btnMusicPathSelect.Name = "btnMusicPathSelect";
            this.btnMusicPathSelect.Size = new System.Drawing.Size(25, 23);
            this.btnMusicPathSelect.TabIndex = 2;
            this.btnMusicPathSelect.Text = "...";
            this.btnMusicPathSelect.UseSelectable = true;
            this.btnMusicPathSelect.Click += new System.EventHandler(this.btnMusicPathSelect_Click);
            // 
            // lblProxyUrl
            // 
            this.lblProxyUrl.AutoSize = true;
            this.lblProxyUrl.Location = new System.Drawing.Point(23, 125);
            this.lblProxyUrl.Name = "lblProxyUrl";
            this.lblProxyUrl.Size = new System.Drawing.Size(108, 19);
            this.lblProxyUrl.TabIndex = 3;
            this.lblProxyUrl.Text = "GMusicProxy Url:";
            // 
            // txtBoxProxyUrl
            // 
            // 
            // 
            // 
            this.txtBoxProxyUrl.CustomButton.Image = null;
            this.txtBoxProxyUrl.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtBoxProxyUrl.CustomButton.Name = "";
            this.txtBoxProxyUrl.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBoxProxyUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxProxyUrl.CustomButton.TabIndex = 1;
            this.txtBoxProxyUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxProxyUrl.CustomButton.UseSelectable = true;
            this.txtBoxProxyUrl.CustomButton.Visible = false;
            this.txtBoxProxyUrl.Lines = new string[0];
            this.txtBoxProxyUrl.Location = new System.Drawing.Point(148, 122);
            this.txtBoxProxyUrl.MaxLength = 32767;
            this.txtBoxProxyUrl.Name = "txtBoxProxyUrl";
            this.txtBoxProxyUrl.PasswordChar = '\0';
            this.txtBoxProxyUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxProxyUrl.SelectedText = "";
            this.txtBoxProxyUrl.SelectionLength = 0;
            this.txtBoxProxyUrl.SelectionStart = 0;
            this.txtBoxProxyUrl.ShortcutsEnabled = true;
            this.txtBoxProxyUrl.Size = new System.Drawing.Size(189, 20);
            this.txtBoxProxyUrl.TabIndex = 4;
            this.txtBoxProxyUrl.UseSelectable = true;
            this.txtBoxProxyUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxProxyUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.Location = new System.Drawing.Point(262, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnToDefault
            // 
            this.btnToDefault.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnToDefault.Location = new System.Drawing.Point(148, 266);
            this.btnToDefault.Name = "btnToDefault";
            this.btnToDefault.Size = new System.Drawing.Size(75, 23);
            this.btnToDefault.TabIndex = 6;
            this.btnToDefault.Text = "To Default";
            this.btnToDefault.UseSelectable = true;
            this.btnToDefault.Click += new System.EventHandler(this.btnToDefault_Click);
            // 
            // lblMusicCount
            // 
            this.lblMusicCount.AutoSize = true;
            this.lblMusicCount.Location = new System.Drawing.Point(23, 171);
            this.lblMusicCount.Name = "lblMusicCount";
            this.lblMusicCount.Size = new System.Drawing.Size(116, 19);
            this.lblMusicCount.TabIndex = 7;
            this.lblMusicCount.Text = "Music result count:";
            // 
            // numMusicCount
            // 
            this.numMusicCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMusicCount.Location = new System.Drawing.Point(148, 169);
            this.numMusicCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMusicCount.Name = "numMusicCount";
            this.numMusicCount.Size = new System.Drawing.Size(189, 23);
            this.numMusicCount.TabIndex = 8;
            this.numMusicCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // chkBoxIgnoreErrors
            // 
            this.chkBoxIgnoreErrors.AutoSize = true;
            this.chkBoxIgnoreErrors.Location = new System.Drawing.Point(148, 224);
            this.chkBoxIgnoreErrors.Name = "chkBoxIgnoreErrors";
            this.chkBoxIgnoreErrors.Size = new System.Drawing.Size(26, 15);
            this.chkBoxIgnoreErrors.TabIndex = 9;
            this.chkBoxIgnoreErrors.Text = " ";
            this.chkBoxIgnoreErrors.UseSelectable = true;
            // 
            // lblIgnoreErrors
            // 
            this.lblIgnoreErrors.AutoSize = true;
            this.lblIgnoreErrors.Location = new System.Drawing.Point(23, 220);
            this.lblIgnoreErrors.Name = "lblIgnoreErrors";
            this.lblIgnoreErrors.Size = new System.Drawing.Size(89, 19);
            this.lblIgnoreErrors.TabIndex = 10;
            this.lblIgnoreErrors.Text = "Ignore Errors:";
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 312);
            this.Controls.Add(this.lblIgnoreErrors);
            this.Controls.Add(this.chkBoxIgnoreErrors);
            this.Controls.Add(this.numMusicCount);
            this.Controls.Add(this.lblMusicCount);
            this.Controls.Add(this.btnToDefault);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxProxyUrl);
            this.Controls.Add(this.lblProxyUrl);
            this.Controls.Add(this.btnMusicPathSelect);
            this.Controls.Add(this.txtBoxMusicPath);
            this.Controls.Add(this.lblMusicPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSettings";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numMusicCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblMusicPath;
        private MetroFramework.Controls.MetroTextBox txtBoxMusicPath;
        private MetroFramework.Controls.MetroButton btnMusicPathSelect;
        private MetroFramework.Controls.MetroLabel lblProxyUrl;
        private MetroFramework.Controls.MetroTextBox txtBoxProxyUrl;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnToDefault;
        private MetroFramework.Controls.MetroLabel lblMusicCount;
        private System.Windows.Forms.NumericUpDown numMusicCount;
        private MetroFramework.Controls.MetroCheckBox chkBoxIgnoreErrors;
        private MetroFramework.Controls.MetroLabel lblIgnoreErrors;
    }
}