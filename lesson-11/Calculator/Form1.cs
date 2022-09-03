namespace Calculator
{
    public partial class CounterForm : Form
    {
        public CounterForm()
        {                                 
            InitializeComponent();
            lblError.BorderStyle = BorderStyle.None;            
        }

        
        private void OnPushCommand(object sender, EventArgs e)
        {
            var t = txtInput.Text;
            int number;
            if(int.TryParse(t, out number))
            {
                listBox1.Items.Add(number);
                txtInput.Text = "";
                lblError.Text = "";
            }
            else
            {
                lblError.Text = $"Not a Number: {t}";
            }                        
        }
        
        private int PerformCalc(int a, int b, char op)
        {
            if (op == '+')
            {
                return a + b;
            }
            else if (op == '-')
            {
                return b - a;
            }
            else if (op == '*')
            {
                return a * b;
            }
            else if (op == '/')
            {
                return b / a;
            }
            return 0;
        }
        private void ExecuteOperation(char op)
        {
            var args = listBox1.Items;
            if (args.Count > 1)
            {
                var last = args.Count - 1;
                var lastNumber = args[last];
                var beforeLastNumber = args[last - 1];

                var a = Convert.ToInt32(lastNumber);
                var b = Convert.ToInt32(beforeLastNumber);
                var result = PerformCalc(a, b, op);

                args.RemoveAt(last);
                args.RemoveAt(last - 1);
                args.Add(result);
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Need Two Numbers";
            }
        }
        private void OnAddOperation(object sender, EventArgs e)
        {
            ExecuteOperation('+');
        }
        
        private void OnSubtractOperation(object sender, EventArgs e)
        {
            ExecuteOperation('-');
        }
        private void OnMulOperation(object sender, EventArgs e)
        {
            ExecuteOperation('*');
        }

        private void OnDivOperation(object sender, EventArgs e)
        {
            ExecuteOperation('/');
        }

        private void OnClearNumbersOperation(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

    }

}