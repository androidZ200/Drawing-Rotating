using System;

namespace Drawing_Rotating
{
    struct Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public Complex(double Re)
        {
            this.Re = Re;
            Im = 0;
        }
        public Complex(double Re, double Im)
        {
            this.Re = Re;
            this.Im = Im;
        }
        public Complex(double Re_Modul, double Im_Angle, bool is_Re_Im)
        {
            if (is_Re_Im)
            {
                Re = Re_Modul;
                Im = Im_Angle;
            }
            else
            {
                Re = Re_Modul * Math.Cos(Im_Angle);
                Im = Re_Modul * Math.Sin(Im_Angle);
            }
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Re + c2.Re, c1.Im + c2.Im);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Re - c2.Re, c1.Im - c2.Im);
        }
        public static Complex operator *(Complex c1, double num)
        {
            return new Complex(c1.Re * num, c1.Im * num);
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Re * c2.Re - c1.Im * c2.Im, c1.Re * c2.Im + c1.Im * c2.Re);
        }
        public static Complex operator /(Complex c1, double num)
        {
            return new Complex(c1.Re / num, c1.Im / num);
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            double d = c2.Re * c2.Re + c2.Im * c2.Im;
            return new Complex((c1.Re * c2.Re + c1.Im * c2.Im) / d, (c1.Im * c2.Re - c1.Re * c2.Im) / d);
        }

        public double Modul()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }
        public double Angle()
        {
            return Math.Atan2(Im, Re);
        }
    }
}
