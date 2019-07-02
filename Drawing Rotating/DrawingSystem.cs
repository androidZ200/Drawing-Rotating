using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace Drawing_Rotating
{
    public class DrawingSystem
    {
        public SystemCircle SystemCircle { get; set; } = new SystemCircle();
        private Thread mainThread;
        private Action<Bitmap> draw;
        private Func<Size> size;
        private object Lock = new object();
        private int daley;
        private Bitmap lastTrail;

        public bool Play { get; private set; } = false;
        public int Daley
        {
            get
            {
                return daley;
            }
            set
            {
                lock (Lock)
                    daley = value;
            }
        }

        public DrawingSystem(Action<Bitmap> draw, Func<Size> size, int daley)
        {
            this.draw = draw;
            this.size = size;
            Daley = daley;
        }

        public void Start()
        {
            if (!Play)
            {
                mainThread = new Thread(Simulation);
                Play = true;
                mainThread.Start();
            }
        }
        public void Stop()
        {
            if (Play)
            {
                Play = false;
            }
        }
        public void Clear()
        {
            if (!Play)
            {
                while (SystemCircle.Count > 0)
                    SystemCircle.RemoveCircle(SystemCircle.GetCircle(0));
                lastTrail = null;
                GC.Collect();
            }
        }

        private void Simulation()
        {
            lastTrail = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(lastTrail);
            while (Play)
            {
                SystemCircle.Teak();
                var s = size();
                if (s.Width > 0 && s.Height > 0)
                {
                    if (s == lastTrail.Size)
                        g.DrawLine(new Pen(SystemCircle.colorTrail, 1),
                            SystemCircle.Trail[SystemCircle.Trail.Count - 1].X + s.Width / 2,
                            SystemCircle.Trail[SystemCircle.Trail.Count - 1].Y + s.Height / 2,
                            SystemCircle.Trail[SystemCircle.Trail.Count - 2].X + s.Width / 2,
                            SystemCircle.Trail[SystemCircle.Trail.Count - 2].Y + s.Height / 2);
                    else
                    {
                        lastTrail = SystemCircle.GetTrail(s.Width, s.Height);
                        g = Graphics.FromImage(lastTrail);
                    }
                    Bitmap bmp;
                    if (SystemCircle.colorCircle != Color.Black)
                        bmp = SystemCircle.GetCircles(s.Width, s.Height);
                    else
                        bmp = new Bitmap(s.Width, s.Height);
                    Graphics g1 = Graphics.FromImage(bmp);
                    g1.DrawImage(lastTrail, 0, 0);
                    draw(bmp);
                }
                else if (lastTrail.Width > 1) lastTrail = new Bitmap(1, 1);
                lock (Lock)
                    Thread.Sleep(daley);
            }
            GC.Collect();
        }
    }
}
