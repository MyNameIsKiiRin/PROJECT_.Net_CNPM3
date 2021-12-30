using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PROJECT_.Net.SanXuat
{
    public partial class FRMKeHoachVatTu : Form
    {
        public FRMKeHoachVatTu()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        int malh=0;
        bool hasData = false;
        private void FRMKeHoachVatTu_Load(object sender, EventArgs e)
        {
            LoadTheme();
            string query = "select * from KeHoachVatTu where MLH="+malh+"";
            ds = DBConnect.Singletion.getData(query, "KeHoach");
            dataGridView1.DataSource = ds.Tables["KeHoach"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hasData = false;
            DataSet ds2 = new DataSet();
            ds2 = DBConnect.Singletion.getData("Select * from LoHang", "LoHang");
            cblohang.DataSource = ds2.Tables["LoHang"];
            cblohang.DisplayMember = "TenLH";
            cblohang.ValueMember = "MaLH";
            hasData = true;
        }
        public void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button button = (Button)btns;
                    button.BackColor = ThemeColor.PrimaryColor;
                    button.ForeColor = Color.White;
                    button.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void cblohang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblohang.SelectedIndex == -1) return;
            if (hasData == false) return;
            malh = (int)cblohang.SelectedValue;
            string query = "select * from KeHoachVatTu where MLH=" + malh + "";
            ds = DBConnect.Singletion.getData(query, "KeHoach");
            dataGridView1.DataSource = ds.Tables["KeHoach"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
