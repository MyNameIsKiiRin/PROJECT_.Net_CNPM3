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
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel3.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Show();
        }
    }
}
