namespace Calculator
{
    enum OperationsEnum
    {
        Add,
        Subtract,
        Multiply,
        Divide,
    }

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
        
        private int PerformCalc(int a, int b, OperationsEnum op)
        {
            switch (op)
            {                
                case OperationsEnum.Add: return a + b;
                case OperationsEnum.Subtract: return a - b;
                case OperationsEnum.Multiply: return a * b;
                case OperationsEnum.Divide: return b / a;
                default: return 0;
            }            
        }
        private void ExecuteOperation(OperationsEnum op)
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
            ExecuteOperation(OperationsEnum.Add);
        }
        
        private void OnSubtractOperation(object sender, EventArgs e)
        {
            ExecuteOperation(OperationsEnum.Subtract);
        }
        private void OnMulOperation(object sender, EventArgs e)
        {
            ExecuteOperation(OperationsEnum.Multiply);
        }

        private void OnDivOperation(object sender, EventArgs e)
        {
            ExecuteOperation(OperationsEnum.Divide);
        }

        private void OnClearNumbersOperation(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

    }

}