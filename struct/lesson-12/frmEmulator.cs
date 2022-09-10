namespace lesson_12
{
    public partial class Emulator : Form
    {
        public Emulator()
        {
            InitializeComponent();
        }

        private void BuildCode ()
        {
            string scode = textBoxCode.Text.Trim();
            string[] raw = scode.Split('\n');
            int l=raw.Length;
            for (int i=0; i<l; i++)
            {
                string word=raw[i].Trim();
                Command c = comp.Decode(i, word);
               
            }
            

        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            comp = new Compiler();
            listBox1.Items.Clear();




        }
    }
}