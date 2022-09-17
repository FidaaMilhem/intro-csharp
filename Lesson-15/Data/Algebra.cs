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
    }
}

