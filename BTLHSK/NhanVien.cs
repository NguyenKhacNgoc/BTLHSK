using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class NhanVien : Form
    {
        string str = "Data Source=KHACNGOC;Initial Catalog=ThietBiMayTinh;Integrated Security=True";
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienNV(sender, e);
        }
        private void HienNV(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(str))
            {
                cnn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("select * from tblNhanVien", cnn))
                {
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    dataGridViewNV.DataSource = tb;
                    dataGridViewNV.AutoResizeColumns();
                    dataGridViewNV.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;


                }

            }
        }
           
        
        
    


    }
}
