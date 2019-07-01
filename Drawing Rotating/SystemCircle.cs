using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Drawing_Rotating
{
    public class SystemCircle
    {
        private List<Circle> circles = new List<Circle>();
        private float slow = 1;

        public List<PointF> Trail { get; set; } = new List<PointF>();
        public Color colorCircle { get; set; } = Color.Gray;
        public Color colorTrail { get; set; } = Color.Red;
        public int Count { get { return circles.Count; } }

        public void AddCircle(Circle c)
        {
            Trail.Clear();
            circles.Add(c);
            checkSlow(c.SpeedAngle);
        }
        public void RemoveCircle(Circle c)
        {
            circles.Remove(c);
            checkSlow();
        }
        public void Teak()
        {
            foreach (var x in circles)
                x.Rotate(slow);
            PointF t = PointF.Empty;
            foreach (var x in circles)
                t = x.GetPoint(t);
            Trail.Add(t);
        }
        public Bitmap GetPicture(int width, int height)
        {
            if (width > 0 && height > 0)
            {

                Bitmap bmp = GetCircles(width, height);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(GetTrail(width, height), 0, 0);
                return bmp;
            }
            return null;
        }
        public Bitmap GetTrail(int width, int height)
        {
            if (width > 0 && height > 0)
            {
                Bitmap bmp = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(bmp);
                PointF center = new PointF(width / 2f, height / 2f);
                var curr = Trail.GetEnumerator();
                if (curr.MoveNext())
                {
                    var prev = curr;
                    while (curr.MoveNext())
                    {
                        g.DrawLine(new Pen(colorTrail, 1), curr.Current.X + center.X, curr.Current.Y + center.Y,
                            prev.Current.X + center.X, prev.Current.Y + center.Y);
                        prev = curr;
                    }
                }
                return bmp;
            }
            return null;
        }
        public Bitmap GetCircles(int width, int height)
        {
            if (width > 0 && height > 0)
            {
                Bitmap bmp = new Bitmap(width, height);
                Graphics g = Graphics.FromImage(bmp);
                PointF center = new PointF(width / 2f, height / 2f);
                foreach (var x in circles)
                {
                    DrawCircle(x, center, g);
                    center = x.GetPoint(center);
                }
                return bmp;
            }
            return null;
        }
        public Circle GetCircle(int index)
        {
            return circles[index];
        }
        public void CheckSlow()
        {
            checkSlow();
        }
        public void Reset()
        {
            Trail.Clear();
            foreach (var x in circles)
                x.Reset();
        }

        private void checkSlow()
        {
            float MaxSpeedAngle = 0;
            foreach (var x in circles)
                if (Math.Abs(x.SpeedAngle) > MaxSpeedAngle)
                    MaxSpeedAngle = Math.Abs(x.SpeedAngle);
            slow = 0.05f / MaxSpeedAngle;
            if (slow > 1f) slow = 1f;
        }
        private void checkSlow(float NewSpeedAngle)
        {
            slow = Math.Min(slow, 0.05f / Math.Abs(NewSpeedAngle));
        }
        private void DrawCircle(Circle c, PointF center, Graphics g)
        {
            var bmp = c.GetPicture(colorCircle);
            PointF centerBMP = new PointF(bmp.Width / 2f, bmp.Height / 2f);
            g.DrawImage(bmp, center.X - centerBMP.X, center.Y - centerBMP.Y);
        }
    }
}
