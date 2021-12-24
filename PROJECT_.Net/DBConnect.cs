using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PROJECT_.Net
{
    class DBConnect
    {
        private SqlConnection con;
        private SqlDataAdapter adt;
        private static DBConnect singletion = null;
        private DataSet ds;

        public static DBConnect Singletion
        {
            get
            {
                if (singletion == null)
                {
                    singletion = new DBConnect();
                }
                return singletion;
            }
        }
        public DBConnect()
        {
            string sql_con = @"Data Source=DESKTOP-88IJ7VF\SQLEXPRESS;Initial Catalog=Xuong_May_Gia_Cong;User ID=sa;pwd=1234567";
            con = new SqlConnection(sql_con);
        }
        public DataSet getData(string query, string table_name)
        {

            ds = new DataSet();
            adt = new SqlDataAdapter(query, con);
            adt.Fill(ds, table_name);
            return ds;

        }
        public bool command(string query)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
