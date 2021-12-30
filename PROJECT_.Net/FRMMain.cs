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
using PROJECT_.Net.VatTu;
using Tulpep.NotificationWindow;
using System.Data.SqlClient;
namespace PROJECT_.Net
{
    public partial class FRMMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FRMMain()
        {
            InitializeComponent();
            random = new Random();
        }
        public Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex==index)
            {
                index=random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        public void ActiveButton(object btnSender)
        {
            if(btnSender!=null)
            {
                if(currentButton!=(Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Microsoft YaHei UI", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }    
            }
        }
        public void DisableButton()
        {
            foreach(Control ctrl in grbsanxuat.Controls)
            {
                if(ctrl.GetType()==typeof(Button))
                {
                    ctrl.BackColor = Color.FromArgb(44, 62, 80);
                    ctrl.ForeColor = Color.Gainsboro;
                    ctrl.Font= new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control ctrl in grbvattu.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    ctrl.BackColor = Color.FromArgb(44, 62, 80);
                    ctrl.ForeColor = Color.Gainsboro;
                    ctrl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control ctrl in grbnhapxuat.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    ctrl.BackColor = Color.FromArgb(44, 62, 80);
                    ctrl.ForeColor = Color.Gainsboro;
                    ctrl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control ctrl in grbhethong.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    ctrl.BackColor = Color.FromArgb(44, 62, 80);
                    ctrl.ForeColor = Color.Gainsboro;
                    ctrl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void OpenChildForm(Form Child,object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(Child);
            this.panelDesktop.Tag = Child;
            Child.BringToFront();
            Child.Show();
            lbltitle.Text = Child.Text;
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
        private void btnyeucausanxuat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRMYeuCauSanXuat(), sender);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRMKeHoachVatTu(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void btndinhmuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRMDinhMucVatTu(), sender);
        }
        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void btndangxuat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void FRMMain_Load(object sender, EventArgs e)
        {
            Noti();
        }

        private void btnCongDoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRMCongDoan(), sender);
        }
        private void btnsanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRMSanPham(), sender);
        }
        private void btnyeucaumuahang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRMYeuCauMuaHang(), sender);
        }

        private void btnvattu_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnnhaphang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnxuathang_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
