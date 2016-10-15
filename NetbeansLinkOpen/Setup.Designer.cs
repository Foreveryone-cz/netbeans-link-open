namespace NetbeansLinkOpen
{
    partial class Setup
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
            this.buttonInstall = new System.Windows.Forms.Button();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelNetbeansPathText = new System.Windows.Forms.Label();
            this.textBoxNetbeansPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInstall
            // 
            this.buttonInstall.Location = new System.Drawing.Point(15, 100);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(287, 62);
            this.buttonInstall.TabIndex = 0;
            this.buttonInstall.Text = "Install handler";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // labelStatusText
            // 
            this.labelStatusText.AutoSize = true;
            this.labelStatusText.Location = new System.Drawing.Point(12, 9);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(40, 13);
            this.labelStatusText.TabIndex = 1;
            this.labelStatusText.Text = "Status:";
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(58, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(244, 40);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "unknown";
            // 
            // labelNetbeansPathText
            // 
            this.labelNetbeansPathText.AutoSize = true;
            this.labelNetbeansPathText.Location = new System.Drawing.Point(12, 49);
            this.labelNetbeansPathText.Name = "labelNetbeansPathText";
            this.labelNetbeansPathText.Size = new System.Drawing.Size(80, 13);
            this.labelNetbeansPathText.TabIndex = 3;
            this.labelNetbeansPathText.Text = "Netbeans path:";
            // 
            // textBoxNetbeansPath
            // 
            this.textBoxNetbeansPath.Location = new System.Drawing.Point(24, 65);
            this.textBoxNetbeansPath.Name = "textBoxNetbeansPath";
            this.textBoxNetbeansPath.Size = new System.Drawing.Size(278, 20);
            this.textBoxNetbeansPath.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 175);
            this.Controls.Add(this.textBoxNetbeansPath);
            this.Controls.Add(this.labelNetbeansPathText);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelStatusText);
            this.Controls.Add(this.buttonInstall);
            this.Name = "Form1";
            this.Text = "Netbeans link opener setup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelNetbeansPathText;
        private System.Windows.Forms.TextBox textBoxNetbeansPath;
    }
}

