namespace Comprog2Project
{
    partial class StartForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SystemTitle = new System.Windows.Forms.Label();
            this.BelowPanel = new System.Windows.Forms.Panel();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.BelowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.MainPanel.Controls.Add(this.LogoPicture);
            this.MainPanel.Controls.Add(this.SystemTitle);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(15);
            this.MainPanel.Size = new System.Drawing.Size(530, 205);
            this.MainPanel.TabIndex = 1;
            // 
            // SystemTitle
            // 
            this.SystemTitle.AutoSize = true;
            this.SystemTitle.Font = new System.Drawing.Font("Cambria", 16.8F);
            this.SystemTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SystemTitle.Location = new System.Drawing.Point(262, 56);
            this.SystemTitle.Name = "SystemTitle";
            this.SystemTitle.Size = new System.Drawing.Size(259, 81);
            this.SystemTitle.TabIndex = 5;
            this.SystemTitle.Text = "Class Attendance \r\n           Managment System\r\n\r\n";
            // 
            // BelowPanel
            // 
            this.BelowPanel.BackColor = System.Drawing.Color.Transparent;
            this.BelowPanel.Controls.Add(this.LoadingBar);
            this.BelowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BelowPanel.Location = new System.Drawing.Point(0, 205);
            this.BelowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BelowPanel.Name = "BelowPanel";
            this.BelowPanel.Size = new System.Drawing.Size(530, 31);
            this.BelowPanel.TabIndex = 0;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoadingBar.Location = new System.Drawing.Point(0, 8);
            this.LoadingBar.MarqueeAnimationSpeed = 50;
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(530, 23);
            this.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoadingBar.TabIndex = 9;
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::Comprog2Project.Properties.Resources.ambystoma_logo2;
            this.LogoPicture.Location = new System.Drawing.Point(12, 34);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(244, 123);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 7;
            this.LogoPicture.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(530, 236);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BelowPanel);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.BelowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label SystemTitle;
        private System.Windows.Forms.Panel BelowPanel;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.PictureBox LogoPicture;
    }
}

