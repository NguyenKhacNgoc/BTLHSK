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
    public partial class RP_CTHDB : Form
    {
        int MaHD;
        public RP_CTHDB(int MaHD)
        {
            InitializeComponent();
            this.MaHD = MaHD;
        }

        private void RP_CTHDB_Load(object sender, EventArgs e)
        {
            void_RP_CT_HDB(MaHD);
            
            
        }
        public void void_RP_CT_HDB (int MaHD)
        {

            sql sql = new sql();
            SqlCommand cmd = sql.EDIT("exec RP_CT_HDB @MaHD");
            cmd.Parameters.AddWithValue("@MaHD", MaHD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);   
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            RP_CT_HDB rp = new RP_CT_HDB();
            rp.SetDataSource(dt);
            crp_CTHDB.ReportSource = rp;
            crp_CTHDB.Refresh();
        }
        

        
    } 
}
