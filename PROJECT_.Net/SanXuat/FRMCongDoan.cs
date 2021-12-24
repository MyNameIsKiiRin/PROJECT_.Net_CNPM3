using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_.Net.SanXuat
{
    public partial class FRMCongDoan : Form
    {
        public FRMCongDoan()
        {
            InitializeComponent();
        }
        private int ViTri = -1;
        DataSet ds = new DataSet();
        public void getData()
        {
            string query = "select * from CongDoan ";
            ds = DBConnect.Singletion.getData(query, "CongDoan");
            dataGridView1.DataSource = ds.Tables["CongDoan"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FRMCongDoan_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
