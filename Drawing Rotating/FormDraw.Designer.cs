namespace Drawing_Rotating
{
    partial class FormDraw
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.CirclesTrackBar = new System.Windows.Forms.TrackBar();
            this.TrackBarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CirclesTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(13, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 482);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(13, 13);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(58, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(78, 13);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(59, 23);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Checked = true;
            this.LoopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LoopCheckBox.Location = new System.Drawing.Point(54, 39);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(50, 17);
            this.LoopCheckBox.TabIndex = 3;
            this.LoopCheckBox.Text = "Loop";
            this.LoopCheckBox.UseVisualStyleBackColor = true;
            // 
            // CirclesTrackBar
            // 
            this.CirclesTrackBar.Location = new System.Drawing.Point(144, 13);
            this.CirclesTrackBar.Maximum = 200;
            this.CirclesTrackBar.Minimum = 5;
            this.CirclesTrackBar.Name = "CirclesTrackBar";
            this.CirclesTrackBar.Size = new System.Drawing.Size(165, 45);
            this.CirclesTrackBar.SmallChange = 5;
            this.CirclesTrackBar.TabIndex = 4;
            this.CirclesTrackBar.Value = 50;
            this.CirclesTrackBar.Scroll += new System.EventHandler(this.CirclesTrackBar_Scroll);
            // 
            // TrackBarLabel
            // 
            this.TrackBarLabel.AutoSize = true;
            this.TrackBarLabel.Location = new System.Drawing.Point(306, 13);
            this.TrackBarLabel.Name = "TrackBarLabel";
            this.TrackBarLabel.Size = new System.Drawing.Size(19, 13);
            this.TrackBarLabel.TabIndex = 5;
            this.TrackBarLabel.Text = "50";
            // 
            // FormDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 551);
            this.Controls.Add(this.TrackBarLabel);
            this.Controls.Add(this.CirclesTrackBar);
            this.Controls.Add(this.LoopCheckBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(387, 413);
            this.Name = "FormDraw";
            this.Text = "FormDraw";
            this.SizeChanged += new System.EventHandler(this.FormDraw_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CirclesTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.CheckBox LoopCheckBox;
        private System.Windows.Forms.TrackBar CirclesTrackBar;
        private System.Windows.Forms.Label TrackBarLabel;
    }
}