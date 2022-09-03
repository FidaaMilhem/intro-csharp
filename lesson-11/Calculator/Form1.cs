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
                

        private void ExecuteOperation(Func<int, int, int> op)
        {
            var args = listBox1.Items;
            if (args.Count > 1)
            {
                var last = args.Count - 1;
                var lastNumber = args[last];
                var beforeLastNumber = args[last - 1];

                var a = Convert.ToInt32(lastNumber);
                var b = Convert.ToInt32(beforeLastNumber);
                var result = op(a, b);

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

        private int add(int a, int b) {
            int r = a;
            for (int i = 0; i < b; i++)
            {
                ++r;
            }
            return r;
        }
        Func<int, int, int> addOp = (a, b) => a + b;
        private void OnAddOperation(object sender, EventArgs e)
        {
            //ExecuteOperation((a,b) => a + b);
            ExecuteOperation(add);
        }
        
        private void OnSubtractOperation(object sender, EventArgs e)
        {
            ExecuteOperation((a, b) => b - a);
        }
        private void OnMulOperation(object sender, EventArgs e)
        {
            ExecuteOperation((a, b) => a * b);
        }
       
        private void OnDivOperation(object sender, EventArgs e)
        {
            ExecuteOperation((a, b) => b / a);
        }

        private void OnClearNumbersOperation(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

    }

}