using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_.Net
{
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void txtacc_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRMLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (txtacc.Text == "admin" && txtpwd.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
        }
    }
}
