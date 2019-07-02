using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Rotating
{
    public partial class FormDraw : Form
    {
        List<Complex> points = new List<Complex>();
        FormMain form;
        bool isDrawing = false;
        Bitmap mainImage;

        void UpdateImage()
        {
            if (pictureBox1.Width > 0 && pictureBox1.Height > 0)
            {
                mainImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(mainImage);
                Point center = new Point(mainImage.Width / 2, mainImage.Height / 2);
                Pen pen = new Pen(Color.Red, 1);
                for (int i = 1; i < points.Count; i++)
                    g.DrawLine(pen, (float)points[i - 1].Re + center.X, (float)points[i - 1].Im + center.Y,
                        (float)points[i].Re + center.X, (float)points[i].Im + center.Y);
                if (LoopCheckBox.Checked && points.Count > 0)
                    g.DrawLine(pen, (float)points[0].Re + center.X, (float)points[0].Im + center.Y,
                        (float)points[points.Count - 1].Re + center.X, (float)points[points.Count - 1].Im + center.Y);
                if (points.Count == 0)
                    g.Clear(Color.Black);
                pictureBox1.Image = mainImage;
            }
        }

        public FormDraw(FormMain form)
        {
            InitializeComponent();
            this.form = form;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            points.Clear();
            UpdateImage();
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (!LoopCheckBox.Checked)
            {
                for (int i = points.Count - 2; i >= 0; i--)
                    points.Add(points[i]);
            }
            form.system.Clear();
            if (points.Count > 0)
            {
                ComplexPoints fun = new ComplexPoints(points, 0, 2 * Math.PI);
                for (int n = CirclesTrackBar.Value / -2, j = 0; j < CirclesTrackBar.Value; j++, n++)
                {
                    var func = fun * new ComplexFunction((x) => new Complex(Math.Cos(n * x), -Math.Sin(n * x)));
                    var integral = func.Integral(0, 2 * Math.PI, 0.002) / (2 * Math.PI);
                    Circle c = new Circle((float)integral.Modul(), (float)integral.Angle(), n);
                    if (c.Radius > 1)
                        form.system.SystemCircle.AddCircle(c);
                }
                form.system.SystemCircle.Sort();
            }
            form.UpdatePicture();
            Close();
        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            points.Add(new Complex(e.X - pictureBox1.Width / 2, e.Y - pictureBox1.Height / 2));
            UpdateImage();
        }
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                points.Add(new Complex(e.X - pictureBox1.Width / 2, e.Y - pictureBox1.Height / 2));
                UpdateImage();
            }
        }
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
        private void CirclesTrackBar_Scroll(object sender, EventArgs e)
        {
            TrackBarLabel.Text = CirclesTrackBar.Value.ToString();
        }
        private void FormDraw_SizeChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }
    }
}
