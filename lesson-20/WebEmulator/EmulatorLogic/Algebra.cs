using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulatorLogic
{
    public class Algebra
    {
        public Algebra()
        {

        }

        public string ExecuteOp(Func<int, int, int> f, string a, string b)
        {
            int arg1;
            int arg2;

            if ((int.TryParse(a, out arg1)) && int.TryParse(b, out arg2))
            {
                int result = f(arg1, arg2);
                return result.ToString();
            }
            return "Error";

        }
        public string AddByString(string str1, string str2)
        {
            //int arg1;
            //int arg2;

            //if ((int.TryParse(a, out arg1)) && int.TryParse(b, out arg2))
            //{
            //    return (arg1 + arg2).ToString();
            //}
            //return "Error";

            return ExecuteOp((a, b) => a + b, str1, str2);

        }

        public string SubtractByString(string str1, string str2)
        {
            return ExecuteOp((a, b) => b - a, str1, str2);
        }
        public string MulByString(string str1, string str2)
        {
            return ExecuteOp((a, b) => a * b, str1, str2);
        }

        public string OnDivOperation(string str1, string str2)
        {
            return ExecuteOp((a, b) => b / a, str1, str2);
        }
        public string OnMudulu(string str1, string str2)
        {
            return ExecuteOp((a, b) => b % a, str1, str2);

        }

        public string Square(string text)
        {
            if (double.TryParse(text, out double result))
            {
                var r = result * result;
                return r.ToString();
            }
            return "Error";
        }

        public string Sqrt(string text)
        {
            if (double.TryParse(text, out double result))
            {
                var r = Math.Sqrt(result);
                return r.ToString();
            }
            return "Error";



        }
    }
}
