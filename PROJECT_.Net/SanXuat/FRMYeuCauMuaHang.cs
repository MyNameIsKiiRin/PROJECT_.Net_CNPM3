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
    public partial class FRMYeuCauMuaHang : Form
    {
        public FRMYeuCauMuaHang()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void FRMYeuCauMuaHang_Load(object sender, EventArgs e)
        {
            string query = "select * from NguyenLieu where SoLuongTon<10 order by SoLuongTon";
            ds = DBConnect.Singletion.getData(query, "NguyenLieu");
            dataGridView1.DataSource = ds.Tables["NguyenLieu"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.FromArgb(44, 62, 80);
        }
    }
}
