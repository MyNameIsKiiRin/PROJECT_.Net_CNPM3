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
            LoadTheme();
        }
        private int ViTri = -1;
        DataSet ds = new DataSet();
        bool hasData = false;
        int malh,macd;
        public void getData()
        {
            string query = "select * from CongDoan ";
            ds = DBConnect.Singletion.getData(query, "CongDoan");
            dataGridView1.DataSource = ds.Tables["CongDoan"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hasData = false;
            DataSet ds2 = new DataSet();
            ds2 = DBConnect.Singletion.getData("Select * from LoHang", "LoHang");
            cblohang.DataSource = ds2.Tables["LoHang"];
            cblohang.DisplayMember = "TenLH";
            cblohang.ValueMember = "MaLH";
            hasData = true;
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        public void LoadTheme()
        {
            foreach (Control btns in groupBox1.Controls)
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {

                String name = textBox1.Text;
                if (name == "") MessageBox.Show("Nhập Dữ Liệu Đi Bạn");
                else
                {
                    string query = "update CongDoan set TenCD= N'" + name + "' where MaCD=" + macd + "";
                    bool kq = DBConnect.Singletion.command(query);
                    if (kq == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        textBox1.Text = "";
                        getData();
                    }

                    else
                        MessageBox.Show("Sửa thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi trong quá trình thực thi");
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "delete from SanPham where CongDoan='" + macd + "'";
                bool kq = DBConnect.Singletion.command(query);
                if (kq == true)
                {
                    MessageBox.Show("Xoá thành công");
                    textBox1.Text = "";
                    getData();
                }

                else
                    MessageBox.Show("Xoá thất bại");
            }
            catch
            {
                MessageBox.Show("Đã có lỗi trong quá trình thực thi");
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox1.Text;
                if (name == "") MessageBox.Show("Nhập Dữ Liệu Đi Bạn");
                else
                {
                    string query = "insert into CongDoan(TenCD,MaLH) values(N'" + name + "'," + malh + ")";
                    bool kq = DBConnect.Singletion.command(query);
                    if (kq == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        textBox1.Text = "";
                        getData();
                    }

                    else
                        MessageBox.Show("Thêm thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thực thi");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FRMCongDoan_Load(object sender, EventArgs e)
        {
            LoadTheme();
            getData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

            e.CellStyle.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void cblohang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblohang.SelectedIndex == -1) return;
            if (hasData == false) return;
            malh = (int)cblohang.SelectedValue;
            string query = "select * from LoHang where MaLH=" + malh + "";
            ds = DBConnect.Singletion.getData(query, "LoHang");
            dataGridView1.DataSource = ds.Tables["LoHang"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = false;
            ViTri = e.RowIndex;
            if (ViTri == -1) return;
            DataRow row = ds.Tables["CongDoan"].Rows[ViTri];
            textBox1.Text = row["TenCD"] + "";
            
            macd = (int)row["MaCD"];
        }
    }
}
