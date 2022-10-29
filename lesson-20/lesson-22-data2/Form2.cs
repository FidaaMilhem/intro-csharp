using lesson_22_data2.MusicStoreTableAdapters;
using lesson_22_data2.NorthwinddsTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_22_data2
{
    public partial class Form2 : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adapter = new CustomersTableAdapter();
            var table = adapter.GetData();

            //listBox1.DataSource = table;
            //listBox1.ValueMember = "CustomerID";

            foreach (var item in table)
            {
                listBox1.Items.Add(item.CustomerID);
            }
        }

        private void OnSelectValueclk(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int si = listBox1.SelectedIndex;
            string a = listBox1.Items[si].ToString();
            listBox2.Items.Add(a);
            listBox2.Items.Add("----------------------------");
            var adapter = new OrdersTableAdapter();
            var table = adapter.GetDataBycustid(a);
            foreach (var item in table)
            {
                listBox2.Items.Add($" [{item.OrderID.ToString()}]    { item.ShipCity.ToString()}   { item.Freight.ToString()}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            sda = new SqlDataAdapter(@"select customerid,contactname,phone FROM Customer",con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "Customers";



        }
    }
}
