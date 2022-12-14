using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Algebra
    {
        public int Add(int a, int b)
        {
            if (b < a)
            {
                var t = a;
                t = b;
                b = t;
            }
            var delta = a < 0 ? -1 : 1;
            int result = b;
            a = a < 0 ? -a : a;
            for (int i = 0; i < a; i++)
            {
                result += delta;
            }
            return result;
        }

        public int Mul(int first, int second)
        {
            int a, b;
            if (first < second)
            {
                a = first;
                b = second;
            }
            else
            {
                a = second;
                b = first;
            }
            var sign = +1;
            if (a < 0 && b > 0) sign = -1;
            if (b <0 && a > 0) sign = -1;
            a = Math.Abs(a);
            b = Math.Abs(b);
            int result = 0;
            for (int i = 0; i < a; i++)
            {
                result += b;
            }
            return sign * result;

        }

        public double Pow(int a, int b)
        {
            if (b == 0) return 1;
            bool isPositive = true;
            if (b < 1) isPositive = false;
            b = Math.Abs(b);
            var r = 1;
            for (int i = 0; i < b; i++)
            {
                r = Mul(r, a);
            }
            return isPositive ? r : 1.0/r;
        }

    }
}

