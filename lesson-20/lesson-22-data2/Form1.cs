using lesson_22_data2.MusicStoreTableAdapters;

namespace lesson_22_data2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            var adapter = new ProductsTableAdapter();
            var table = adapter.GetData();
            
            listBox1.DataSource = table;
            listBox1.DisplayMember = "ProductName";
            listBox1.ValueMember = "ProductId";

            //MusicStore.ProductsDataTable t = new MusicStore.ProductsDataTable();
            //adapter.Fill(t);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var adapter = new ProductsTableAdapter();
            var table = adapter.GetDataByLowThan(10);

            listBox1.DataSource = table;
            listBox1.DisplayMember = "ProductName";
            listBox1.ValueMember = "ProductId";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var adapter = new ProductsTableAdapter();
            var n = adapter.Count();
            button1.Text = n.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var adapter = new CategoriesTableAdapter();
            var catgs = adapter.GetData();

            foreach (var cat in catgs)
            {
                listBox2.Items.Add(cat.CategoryName);
            }

            listBox3.Items.Add(catgs[2].CategoryName);
            var pp = catgs[2].GetChildRows("CatProd");
            listBox3.Items.Add("---");
            foreach (var item in pp)
            {
                listBox3.Items.Add(item.ItemArray[3].ToString());
            }

        }
    }
}