using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Drawing_Rotating
{
    public partial class FormMain : Form
    {
        public DrawingSystem system;

        private void Draw(Bitmap bmp)
        {
            Invoke((Action)(() => { pictureBox1.Image = bmp; }));
        }
        private Size GetSize()
        {
            return pictureBox1.Size;
        }
        public void UpdatePicture()
        {
            pictureBox1.Image = system.SystemCircle.GetPicture(pictureBox1.Width, pictureBox1.Height);
        }

        public FormMain()
        {
            InitializeComponent();
            system = new DrawingSystem(Draw, GetSize, SpeedTrackBar.Value);
        }
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if(system.Play)
            {
                StartStopButton.Text = "Start";
                system.Stop();
            }
            else
            {
                StartStopButton.Text = "Stop";
                system.Start();
            }
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (system.Play) StartStopButton_Click(sender, e);
            FormCircles form = new FormCircles(system.SystemCircle, this);
            form.ShowDialog();
        }
        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            system.Daley = SpeedTrackBar.Value;
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (system.Play)
                StartStopButton_Click(sender, e);
            system.SystemCircle.Reset();
            UpdatePicture();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            system.Stop();
            Thread.Sleep(40);
        }
        private void ColorTrackBar_Scroll(object sender, EventArgs e)
        {
            system.SystemCircle.colorCircle = Color.FromArgb(ColorTrackBar.Value, ColorTrackBar.Value, ColorTrackBar.Value);
        }
        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            UpdatePicture();
        }
        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (system.Play)
                StartStopButton_Click(sender, e);
            FormDraw form = new FormDraw(this);
            form.ShowDialog();
        }
    }
}
