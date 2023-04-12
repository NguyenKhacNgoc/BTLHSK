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
    public partial class TestCRP : Form
    {
        public TestCRP()
        {
            InitializeComponent();
        }

        private void TestCRP_Load(object sender, EventArgs e)
        {

        }
        public void RP_NgayBan()
        {
            sql sql = new sql();
            SqlCommand cmd = sql.EDIT("exec RP_GiaBan @a, @b");
            cmd.Parameters.AddWithValue("@a", textBox1.Text);
            cmd.Parameters.AddWithValue("@b", textBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            RP_CT_HDB rp = new RP_CT_HDB();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RP_NgayBan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql sql = new sql();
            SqlCommand cmd = sql.EDIT("exec TestRPVIDU2 @thang, @nam");
            cmd.Parameters.AddWithValue("@thang", textBox3.Text);
            cmd.Parameters.AddWithValue("@nam", textBox4.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            testvidu2 testvidu2 = new testvidu2();
            testvidu2.SetDataSource(dt);

            crystalReportViewer1.ReportSource = testvidu2;
            crystalReportViewer1.Refresh();
        }
    }
}
