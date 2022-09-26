using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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
            return ExecuteOp((a, b) => a + b, str1, str2);

        }

        public string SubtractByString(string str1, string str2)
        {
            return ExecuteOp((a, b) => a - b, str1, str2);
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
            return ExecuteOp((a, b) => a % b, str1, str2);

        }
        
        //private void OnSubtractOperation(object sender, EventArgs e)
        //{
        //    ExecuteOperation((a, b) => b - a);
        //}
        //private void OnMulOperation(object sender, EventArgs e)
        //{
        //    ExecuteOperation((a, b) => a * b);
        //}

        //private void OnDivOperation(object sender, EventArgs e)
        //{
        //    ExecuteOperation((a, b) => b / a);
        //}
        //private void OnMudulu(object sender, EventArgs e)
        //{
        //    ExecuteOperation((a, b) => a % b);
        //}
        //private void btnBower_Click(object sender, EventArgs e)
        //{
        //    ExecuteOperation((a, b) => (int)Math.Pow(a, b));
        //}
        //private void OnbtnSwap(object sender, EventArgs e)
        //{
        //    var args = listBox1.Items;
        //    if (args.Count > 1)
        //    {
        //        var last = args.Count - 1;
        //        var lastNumber = args[last];
        //        var beforeLastNumber = args[last - 1];

        //        var a = Convert.ToInt32(lastNumber);
        //        var b = Convert.ToInt32(beforeLastNumber);
        //        args[last] = b;
        //        args[last - 1] = a;

        //    }
        //}
        //private void btnRotat3_Click(object sender, EventArgs e)
        //{
        //    var args = listBox1.Items;
        //    if (args.Count > 3)
        //    {

        //        var last = args.Count - 1;
        //        var lastNumber = args[last];
        //        var a = Convert.ToInt32(lastNumber);

        //        args.RemoveAt(last);
        //        args.Insert(last - 2, a);

        //    }
        //}

        //private void btnSort_Click(object sender, EventArgs e)
        //{
        //    var args = listBox1.Items;
        //    var last = args.Count - 1;
        //    var lastNumber = args[last];
        //    var a = Convert.ToInt32(lastNumber);
        //    if (a > 0) args[last] = Math.Sqrt(a);
        //    else lblError.Text = "negative number";
        //}
        //private void OnAbs(object sender, EventArgs e)
        //{
        //    var args = listBox1.Items;
        //    var last = args.Count - 1;
        //    var lastNumber = args[last];
        //    var a = Convert.ToInt32(lastNumber);
        //    if (a < 0) args[last] = -a;


        //}

    }
}
