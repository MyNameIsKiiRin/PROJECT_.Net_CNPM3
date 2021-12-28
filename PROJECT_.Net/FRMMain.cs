using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_.Net.SanXuat;
using Tulpep.NotificationWindow;
using System.Data.SqlClient;
namespace PROJECT_.Net
{
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
        }
        
        public void Noti()
        {
            string sql_con = @"Data Source=DESKTOP-88IJ7VF\SQLEXPRESS;Initial Catalog=Xuong_May_Gia_Cong;User ID=sa;pwd=1234567";
            SqlConnection con = new SqlConnection(sql_con);
            con.Open();
            PopupNotifier popup = new PopupNotifier();
            string query = "select count(*) from NguyenLieu where SoLuongTon<10 ";
            SqlCommand cmd = new SqlCommand(query, con);
            int kq = (int)cmd.ExecuteScalar();
            if (kq > 0)
            {

                popup.TitleText = "Cảnh Báo";
                popup.ContentText = "Một Số Nguyên Liệu Trong Kho Hàng Đã Hết, Vui Lòng Nhanh Chóng Bổ Xung Để Không Làm Gián Đoạn Công Việc";
                popup.Popup();// show
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void FRMMain_Load(object sender, EventArgs e)
        {
            Noti();
        }

        private void btnCongDoan_Click(object sender, EventArgs e)
        {

        }
    }
}
