using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Runtime.CompilerServices;

namespace BTLHSK
{
    class sql
    {
        public string str = "Data Source=KHACNGOC;Initial Catalog=ThietBiMayTinh;Integrated Security=True";
        public SqlConnection cnn = new SqlConnection();
        public bool ketnoi()
        {
            try
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
                cnn.ConnectionString = str;
                cnn.Open();

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
        public DataTable getDB(string stri)
        {
            ketnoi();
            SqlDataAdapter da = new SqlDataAdapter(stri, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void combobox(string command, string Tencmb, ComboBox cmb)
        {
            ketnoi();
            SqlCommand cmd = new SqlCommand(command, cnn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cmb.Items.Add(sdr[Tencmb].ToString());

            }
        }
        public SqlCommand EDIT(string edit)
        {
            ketnoi();
            SqlCommand cmd = new SqlCommand(edit, cnn);
            return cmd;

        }
        
        
    }
}
