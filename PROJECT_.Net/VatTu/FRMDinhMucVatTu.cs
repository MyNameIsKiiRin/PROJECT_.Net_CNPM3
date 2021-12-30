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
using System.Data;
namespace PROJECT_.Net.VatTu
{
    public partial class FRMDinhMucVatTu : Form
    {
        public FRMDinhMucVatTu()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        bool hasData = false;
        int malh = 0;
        int ViTri = -1;
        int masp,soluong;
        List<int> ID = new List<int>();
        List<string> name = new List<string>();
        string name_;
        public void LoadTheme()
        {
            foreach (Control btns in groupBox2.Controls)
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
        public void getData()
        {
            //string query = "select * from SanPham where MaLH='" + malh + "'";
            //ds = DBConnect.Singletion.getData(query, "SanPham");
            //dataGridView1.DataSource = ds.Tables["SanPham"];
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hasData = false;
            DataSet ds2 = new DataSet();
            ds2 = DBConnect.Singletion.getData("Select * from LoHang", "LoHang");
            cblohang.DataSource = ds2.Tables["LoHang"];
            cblohang.DisplayMember = "TenLH";
            cblohang.ValueMember = "MaLH";
            hasData = true;
            DataSet ds3 = new DataSet();
            ds3 = DBConnect.Singletion.getData("select * from NguyenLieu", "NguyenLieu");
            ((ListBox)checkedListBox1).DataSource = ds3.Tables["NguyenLieu"];
            ((ListBox)checkedListBox1).DisplayMember = "TenNL";
            ((ListBox)checkedListBox1).ValueMember = "MaNL";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FRMDinhMucVatTu_Load(object sender, EventArgs e)
        {
            LoadTheme();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool result = false;
            bool result2 = false;
            bool result3 = false;
            
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                int id =(int) castedItem["MaNL"];
                string name_ = castedItem["TenNL"]+"";
                ID.Add(id);
                name.Add(name_);
            }
            int total = 0;
            if (int.TryParse( txtsoluong.Text, out total) == false)
            {
                MessageBox.Show("Nhập cho đúng vào ");
                return;
            }
            foreach (var item in ID)
            {
                string query = "insert into NguyenLieuCanDung(MaNL,MaSP,SoLuongCan) values(" + item + "," +
                    "" + masp + "," + total + ")";
                result = DBConnect.Singletion.command(query);

                string query_2 = "update NguyenLieu set SoLuongTon-=" + total + " where MaNL=" + item + "";
                result2 = DBConnect.Singletion.command(query_2);

            }
            foreach (var item in name)
            {
                string query_3 = "insert into KeHoachVatTu(MLH,SanPham,VatTu,SoLuongCan,TrangThai,UuTien,DonVi)" +
                    " values(" + malh + ",'" + name_ + "','"+item+"',"+total*soluong+",1,1)";
                result3 = DBConnect.Singletion.command(query_3);

            }
            if (result && result2 && result3)
            {
                txtsoluong.Text = "";
                MessageBox.Show("Định mức thành công");
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Color.FromArgb(44, 62, 80);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViTri = e.RowIndex;
            if (ViTri == -1) return;
            DataRow row = ds.Tables["SanPham"].Rows[ViTri];
            masp = (int)row["MaSP"] ;
            soluong = (int)row["SoLuong"];
            name_ = row["TenSP"] + "";
        }
    }
}
