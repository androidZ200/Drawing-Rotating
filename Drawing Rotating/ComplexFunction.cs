using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Rotating
{
    abstract class IComplexFunction
    {
        public abstract Complex Get(double X);

        public static ComplexFunction operator +(IComplexFunction cf1, IComplexFunction cf2)
        {
            return new ComplexFunction((x) => cf1.Get(x) + cf2.Get(x));
        }
        public static ComplexFunction operator +(IComplexFunction cf1, Complex cf2)
        {
            return new ComplexFunction((x) => cf1.Get(x) + cf2);
        }
        public static ComplexFunction operator *(IComplexFunction cf1, IComplexFunction cf2)
        {
            return new ComplexFunction((x) => cf1.Get(x) * cf2.Get(x));
        }
        public static ComplexFunction operator *(IComplexFunction cf1, Complex cf2)
        {
            return new ComplexFunction((x) => cf1.Get(x) + cf2);
        }

        public Complex Integral (double a, double b, double step)
        {
            Complex sum = new Complex();
            while(a + step < b)
            {
                sum += Get(a + step / 2) * step;
                a += step;
            }
            return sum;
        }
    }

    class ComplexPoints : IComplexFunction
    {
        List<Complex> points = new List<Complex>();
        public double Begin { get; private set; }
        public double End { get; private set; }

        public ComplexPoints(List<Complex> func, double beg, double end)
        {
            points = func;
            Begin = beg;
            End = end;
        }

        public override Complex Get(double X)
        {
            if (X < Begin || X > End) throw new IndexOutOfRangeException();
            X = (X - Begin) / (End - Begin) * (points.Count - 1);
            int iX = (int)X;
            if (iX == X) return points[iX];
            double dX = X - iX;
            return points[iX] * (1 - dX) + points[iX + 1] * dX;
        }
    }
    class ComplexFunction : IComplexFunction
    {
        Func<double, Complex> func;

        public ComplexFunction(Func<double, Complex> func)
        {
            this.func = func;
        }

        public override Complex Get(double X)
        {
            return func(X);
        }
    }
}
