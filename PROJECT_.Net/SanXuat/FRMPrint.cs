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
using Microsoft.Reporting.WinForms;
namespace PROJECT_.Net.SanXuat
{
    public partial class FRMPrint : Form
    {
        public int mayc;
        public FRMPrint()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        public FRMPrint(int id):this()
        {
            mayc = id;
        }
        private void FRMPrint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string query = "select * from YeuCauSanXuat where MaYC= "+mayc+"";
            ds = DBConnect.Singletion.getData(query, "YeuCau");
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROJECT_.Net.SanXuat.Report1.rdlc";
            ReportDataSource reportData = new ReportDataSource();
            reportData.Name = "DataSet1";
            reportData.Value = ds.Tables["YeuCau"];
            this.reportViewer1.LocalReport.DataSources.Add(reportData);
            this.reportViewer1.RefreshReport();
        }
    }
}
