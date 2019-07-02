using System;
using System.Drawing;

namespace Drawing_Rotating
{
    public class Circle
    {
        public float Radius { get; set; }
        public float StartAngle { get; set; }
        public float CurrentAngle { get; set; }
        public float SpeedAngle { get; set; }

        public Circle(float Radius, float Angle, float Speed)
        {
            this.Radius = Radius;
            StartAngle = CurrentAngle = Angle;
            SpeedAngle = Speed;
        }

        public void Rotate(float slow)
        {
            CurrentAngle += SpeedAngle * slow;
            if (CurrentAngle < 0) CurrentAngle += (float)(2 * Math.PI);
            else if (CurrentAngle >= (float)(2 * Math.PI)) CurrentAngle -= (float)(2 * Math.PI);
        }
        public PointF GetPoint()
        {
            return new PointF((float)(Radius * Math.Cos(CurrentAngle)), (float)(Radius * Math.Sin(CurrentAngle)));
        }
        public PointF GetPoint(PointF center)
        {
            var t = GetPoint();
            return new PointF(center.X + t.X, center.Y + t.Y);
        }
        public Bitmap GetPicture(Color color)
        {
            Bitmap bmp = new Bitmap((int)(Radius * 2) + 2, (int)(Radius * 2) + 2);
            Graphics g = Graphics.FromImage(bmp);
            Pen pen = new Pen(color, 1);
            g.DrawEllipse(pen, 1, 1, bmp.Width - 2, bmp.Height - 2);
            var t = GetPoint(new PointF(bmp.Width / 2, bmp.Height / 2));
            g.DrawLine(pen, bmp.Width / 2, bmp.Height / 2, t.X, t.Y);
            return bmp;
        }
        public void Reset()
        {
            CurrentAngle = StartAngle;
        }
    }
}
