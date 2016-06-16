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
            this.lblMusicPath = new System.Windows.Forms.Label();
            this.txtBoxMusicPath = new System.Windows.Forms.TextBox();
            this.btnMusicPathSelect = new System.Windows.Forms.Button();
            this.lblProxyUrl = new System.Windows.Forms.Label();
            this.txtBoxProxyUrl = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnToDefault = new System.Windows.Forms.Button();
            this.lblMusicCount = new System.Windows.Forms.Label();
            this.numMusicCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMusicCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusicPath
            // 
            this.lblMusicPath.AutoSize = true;
            this.lblMusicPath.Location = new System.Drawing.Point(13, 13);
            this.lblMusicPath.Name = "lblMusicPath";
            this.lblMusicPath.Size = new System.Drawing.Size(63, 13);
            this.lblMusicPath.TabIndex = 0;
            this.lblMusicPath.Text = "Music Path:";
            // 
            // txtBoxMusicPath
            // 
            this.txtBoxMusicPath.Location = new System.Drawing.Point(138, 10);
            this.txtBoxMusicPath.Name = "txtBoxMusicPath";
            this.txtBoxMusicPath.Size = new System.Drawing.Size(189, 20);
            this.txtBoxMusicPath.TabIndex = 1;
            // 
            // btnMusicPathSelect
            // 
            this.btnMusicPathSelect.Location = new System.Drawing.Point(333, 8);
            this.btnMusicPathSelect.Name = "btnMusicPathSelect";
            this.btnMusicPathSelect.Size = new System.Drawing.Size(25, 23);
            this.btnMusicPathSelect.TabIndex = 2;
            this.btnMusicPathSelect.Text = "...";
            this.btnMusicPathSelect.UseVisualStyleBackColor = true;
            this.btnMusicPathSelect.Click += new System.EventHandler(this.btnMusicPathSelect_Click);
            // 
            // lblProxyUrl
            // 
            this.lblProxyUrl.AutoSize = true;
            this.lblProxyUrl.Location = new System.Drawing.Point(13, 61);
            this.lblProxyUrl.Name = "lblProxyUrl";
            this.lblProxyUrl.Size = new System.Drawing.Size(88, 13);
            this.lblProxyUrl.TabIndex = 3;
            this.lblProxyUrl.Text = "GMusicProxy Url:";
            // 
            // txtBoxProxyUrl
            // 
            this.txtBoxProxyUrl.Location = new System.Drawing.Point(138, 58);
            this.txtBoxProxyUrl.Name = "txtBoxProxyUrl";
            this.txtBoxProxyUrl.Size = new System.Drawing.Size(189, 20);
            this.txtBoxProxyUrl.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnToDefault
            // 
            this.btnToDefault.Location = new System.Drawing.Point(138, 142);
            this.btnToDefault.Name = "btnToDefault";
            this.btnToDefault.Size = new System.Drawing.Size(75, 23);
            this.btnToDefault.TabIndex = 6;
            this.btnToDefault.Text = "To Default";
            this.btnToDefault.UseVisualStyleBackColor = true;
            this.btnToDefault.Click += new System.EventHandler(this.btnToDefault_Click);
            // 
            // lblMusicCount
            // 
            this.lblMusicCount.AutoSize = true;
            this.lblMusicCount.Location = new System.Drawing.Point(13, 107);
            this.lblMusicCount.Name = "lblMusicCount";
            this.lblMusicCount.Size = new System.Drawing.Size(96, 13);
            this.lblMusicCount.TabIndex = 7;
            this.lblMusicCount.Text = "Music result count:";
            // 
            // numMusicCount
            // 
            this.numMusicCount.Location = new System.Drawing.Point(138, 105);
            this.numMusicCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMusicCount.Name = "numMusicCount";
            this.numMusicCount.Size = new System.Drawing.Size(189, 20);
            this.numMusicCount.TabIndex = 8;
            this.numMusicCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 175);
            this.Controls.Add(this.numMusicCount);
            this.Controls.Add(this.lblMusicCount);
            this.Controls.Add(this.btnToDefault);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxProxyUrl);
            this.Controls.Add(this.lblProxyUrl);
            this.Controls.Add(this.btnMusicPathSelect);
            this.Controls.Add(this.txtBoxMusicPath);
            this.Controls.Add(this.lblMusicPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numMusicCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusicPath;
        private System.Windows.Forms.TextBox txtBoxMusicPath;
        private System.Windows.Forms.Button btnMusicPathSelect;
        private System.Windows.Forms.Label lblProxyUrl;
        private System.Windows.Forms.TextBox txtBoxProxyUrl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnToDefault;
        private System.Windows.Forms.Label lblMusicCount;
        private System.Windows.Forms.NumericUpDown numMusicCount;
    }
}