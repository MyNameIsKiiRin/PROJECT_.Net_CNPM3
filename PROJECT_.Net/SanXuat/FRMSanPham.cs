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
    public partial class FRMSanPham : Form
    {
        public FRMSanPham()
        {
            InitializeComponent();
        }
        private int ViTri = -1;
        DataSet ds = new DataSet();
        bool hasData = false;
        int malh = 1;
        int masp;

        public void getData()
        {
            string query = "select * from SanPham where MaLH='" + malh + "'";
            ds = DBConnect.Singletion.getData(query, "SanPham");
            dataGridView1.DataSource = ds.Tables["SanPham"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hasData = false;
            DataSet ds2 = new DataSet();
            ds2 = DBConnect.Singletion.getData("Select * from LoHang", "LoHang");
            cblohang.DataSource = ds2.Tables["LoHang"];
            cblohang.DisplayMember = "TenLH";
            cblohang.ValueMember = "MaLH";
            hasData = true;
        }
        public void clear()
        {
            txtsoluong.Text = "";
            txtdongia.Text = "";
            txttensp.Text = "";
        }

        private void FRMSanPham_Load(object sender, EventArgs e)
        {
            getData();
            btnxoasp.Enabled = false;
            btnsuasp.Enabled = false;
            btnthemsp.Enabled = true;
            btndinhmua.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnxoasp.Enabled = false;
            btnsuasp.Enabled = false;
            btnthemsp.Enabled = true;
            btndinhmua.Enabled = false;
            clear();
        }
        private void btnsuasp_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txttensp.Text;
                decimal price = 0;
                int total = 0;
                try
                {
                    price = int.Parse(txtdongia.Text);
                    total = int.Parse(txtsoluong.Text);
                }
                catch
                {
                    MessageBox.Show("Dữ Liệu Nhập Không Đúng");
                }
                string query = "update SanPham set TenSP= N'" + name + "', DonGia=N'" + price + "',SoLuong=N'" + total + "' where MaSP=" + masp + "";
                bool kq = DBConnect.Singletion.command(query);
                if (kq == true)
                {
                    MessageBox.Show("Sửa thành công");
                    clear();
                    getData();
                }

                else
                    MessageBox.Show("Sửa thất bại");
            }
            catch
            {
                MessageBox.Show("Đã có lỗi trong quá trình thực thi");
            }
        }
        private void btnxoasp_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "delete from SanPham where MaSP='" + masp + "'";
                bool kq = DBConnect.Singletion.command(query);
                if (kq == true)
                {
                    MessageBox.Show("Xoá thành công");
                    clear();
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
        private void btnthemsp_Click(object sender,EventArgs e)
        {
            try
            {
                String name = txttensp.Text;
                decimal price = 0;
                int total = 0;
                if (Decimal.TryParse(txtdongia.Text, out price) == false || int.TryParse(txtsoluong.Text, out total) == false) return;
                try
                {
                    price = int.Parse(txtdongia.Text);
                    total = int.Parse(txtsoluong.Text);
                }
                catch
                {
                    MessageBox.Show("Dữ Liệu Nhập Không Đúng");
                }
                string query = "insert into SanPham(TenSP,SoLuong,DonGia,MaLH) values(N'" + name + "','" + total + "','" + price + "','" + malh + "')";
                bool kq = DBConnect.Singletion.command(query);
                if (kq == true)
                {
                    MessageBox.Show("Thêm thành công");
                    clear();
                    getData();
                }

                else
                    MessageBox.Show("Thêm thất bại");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thực thi");
            }
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            getData();
        }
        private void cblohang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblohang.SelectedIndex == -1) return;
            if (hasData == false) return;
            malh = (int)cblohang.SelectedValue;
            string query = "select * from SanPham where MaLH=" + malh;
            ds = DBConnect.Singletion.getData(query, "SanPham");
            dataGridView1.DataSource = ds.Tables["SanPham"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnxoasp.Enabled = true;
            btnsuasp.Enabled = true;
            btnthemsp.Enabled = false;
            btndinhmua.Enabled = true;
            ViTri = e.RowIndex;
            if (ViTri == -1) return;
            DataRow row = ds.Tables["SanPham"].Rows[ViTri];
            txttensp.Text = row["TenSP"] + "";
            masp = (int)row["MaSP"];
            txtdongia.Text = row["DonGia"] + "";
            txtsoluong.Text = row["SoLuong"] + "";
        }
        private void btnchonnhanvien_Click(object sender, EventArgs e)
        {
            
        }
    }
}
