namespace Calculator
{
    public partial class CounterForm : Form
    {
        public double Value { get; set; }

        public CounterForm()
        {            
            Value = 0;            
            InitializeComponent();
            lblError.BorderStyle = BorderStyle.None;
            lblCounter.Text = Value.ToString();
        }

        private void UpdateDisplay()
        {
            lblCounter.Text = Value.ToString();
        }

        private void OnButtonnUp(object sender, EventArgs e)
        {
            lblError.Text = "";
            Value += 1;
            UpdateDisplay();

            if(listBox1.Items.Count > 0)
            {
                lblError.Text = listBox1.Items[0].ToString();
            }
        }

        private void OnButtonDown(object sender, EventArgs e)
        {
            lblError.Text = "";
            Value -= 1;
            UpdateDisplay();
            //listBox1.Items.Add(13);
            //listBox1.Items.Add(27);
        }

        private void OnButtonReset(object sender, EventArgs e)
        {
            var t = txtInput.Text;

            int n;
            if( int.TryParse(t, out n))
            {
                Value = n;
                UpdateDisplay();
                lblError.Text = "";
            }
            else
            {
                lblError.Text = $"Not a Number: {t}";
            }

            txtInput.Text = "";
        }

        private void button1_add(object sender, EventArgs e)
        {
            
            double sum = Value;
            int c = listBox1.Items.Count;
            if (listBox1.Items.Count > 0)
            {
                
                for (int i = 0; i < 2; i++)
                {
                    sum += Convert.ToDouble(listBox1.Items[c-1-i]);
                }
                 
            }
            listBox1.Items.RemoveAt(c - 1);
            Value = sum;
            lblCounter.Text = sum.ToString();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            double mul;
            if (Value != 0) mul = Value;
            else mul = 1;   
            int c = listBox1.Items.Count;
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    mul *= Convert.ToDouble(listBox1.Items[c - 1 - i]);
                }
                
            }
           
            Value = mul;
            listBox1.Items.RemoveAt(c - 1);
            lblCounter.Text = mul.ToString();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lblCounter.Text = "";
        }
    }
    
}