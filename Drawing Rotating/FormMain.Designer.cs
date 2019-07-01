namespace Drawing_Rotating
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ColorTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 525);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartStopButton
            // 
            this.StartStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartStopButton.Location = new System.Drawing.Point(729, 13);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(80, 33);
            this.StartStopButton.TabIndex = 1;
            this.StartStopButton.Text = "Start";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.Location = new System.Drawing.Point(729, 91);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(80, 33);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedTrackBar.Location = new System.Drawing.Point(729, 131);
            this.SpeedTrackBar.Maximum = 40;
            this.SpeedTrackBar.Minimum = 1;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(80, 45);
            this.SpeedTrackBar.TabIndex = 3;
            this.SpeedTrackBar.Value = 20;
            this.SpeedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(729, 52);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(80, 33);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ColorTrackBar
            // 
            this.ColorTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorTrackBar.Location = new System.Drawing.Point(730, 168);
            this.ColorTrackBar.Maximum = 255;
            this.ColorTrackBar.Name = "ColorTrackBar";
            this.ColorTrackBar.Size = new System.Drawing.Size(79, 45);
            this.ColorTrackBar.TabIndex = 5;
            this.ColorTrackBar.Value = 100;
            this.ColorTrackBar.Scroll += new System.EventHandler(this.ColorTrackBar_Scroll);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 550);
            this.Controls.Add(this.ColorTrackBar);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SpeedTrackBar);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(421, 343);
            this.Name = "FormMain";
            this.Text = "Drawing Rotating";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TrackBar ColorTrackBar;
    }
}

