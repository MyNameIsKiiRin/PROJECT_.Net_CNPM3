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
    public partial class FRMYeuCauSanXuat : Form
    {
        public FRMYeuCauSanXuat()
        {
            InitializeComponent();
        }

        private int ViTri = -1;
        DataSet ds = new DataSet();
        bool hasData = false;
        int malh = 1;
        int mayc;
        DateTime ngayyeucau;
        DateTime ngayketthuc;
        public void getData()
        {
            string query = "select * from YeuCauSanXuat order by DoUuTien";
            ds = DBConnect.Singletion.getData(query, "YeuCau");
            dataGridView1.DataSource = ds.Tables["YeuCau"];
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
            txtut.Text = "";
            cblohang.SelectedIndex = -1;
            cbtrangthai.SelectedIndex = -1;
        }
        private void FRMYeuCauSanXuat_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cblohang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblohang.SelectedIndex == -1) return;
            if (hasData == false) return;
            malh = (int)cblohang.SelectedValue;
            string query = "select * from YeuCauSanXuat where MaLH=" + malh;
            ds = DBConnect.Singletion.getData(query, "YeuCau");
            dataGridView1.DataSource = ds.Tables["YeuCau"];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnyc_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txtsoluong, "");
                errorProvider2.SetError(txtut, "");
                string query = "select * from LoHang where MaLH='" + malh + "'";
                SqlDataReader reader = DBConnect.Singletion.getDataReader(query);
                //int soluong = (int)reader["TongSanPham"];
                int soluong = 0;
                while (reader.Read())
                {
                    soluong = (int)reader["TongSanPham"];
                }
                DBConnect.Singletion.Disconnect();
                int total = 0;
                int ut = 0;
                int trangthai = cbtrangthai.SelectedItem == "Sống" ? 1 : 0;
                if (trangthai == -1) trangthai = 1;
                if (Int32.TryParse(txtsoluong.Text, out total) && Int32.TryParse(txtut.Text, out ut))
                {
                    if (total > soluong) errorProvider1.SetError(txtsoluong, "Vượt quá tổng số sản phẩm trong lô hàng");
                    else
                    {
                        if (ut > 10) errorProvider2.SetError(txtut, "Độ ưu tiên không được vượt quá 10");
                        else
                        {
                            string query_insert = "insert into YeuCauSanXuat(MaLH,SoLuong,NgayYeuCau,NgayHoanThanh,DoUuTien,TrangThai)" +
                                "values(" + malh + "," + total + "," + ngayyeucau.ToString("yyyy/MM/dd") + "," + ngayketthuc.ToString("yyyy/MM/dd") + "," + ut + "," + trangthai + ")";
                            bool kq = DBConnect.Singletion.command(query_insert);
                            if (kq == true)
                            {
                                getData();
                                clear();
                                MessageBox.Show("Thêm thành công");

                            }

                            else
                                MessageBox.Show("Thêm thất bại");
                        }

                    }
                }
                else
                    MessageBox.Show("Nhập dữ liệu đi bạn ");
            }
            catch 
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void dtpkyc_ValueChanged(object sender, EventArgs e)
        {
            ngayyeucau = dtpkyc.Value;
        }

        private void dtpkdate_ValueChanged(object sender, EventArgs e)
        {
            ngayketthuc = dtpkdate.Value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btninan_Click(object sender, EventArgs e)
        {
            FRMPrint print = new FRMPrint(mayc);
            print.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViTri = e.RowIndex;
            if (ViTri == -1) return;
            DataRow row = ds.Tables["YeuCau"].Rows[ViTri];
            mayc = int.Parse(row["MaYC"] + "");
        }
    }
}
