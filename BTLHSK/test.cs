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

namespace BTLHSK
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            cb();
            hiengrv();
        }
        private void cb()
        {
            sql sql = new sql();
            sql.ketnoi();
            SqlCommand cmd = new SqlCommand("select iMaNV FROM tblNhanVien", sql.cnn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd["iMaNV"].ToString());

            }
        }
        private void hiengrv()
        {
            sql sql = new sql();
            DataTable dt = sql.getDB("select * from v_NV");
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql sql = new sql();
            DataTable dt =  sql.getDB("select * from v_NV");
            dataGridView1.DataSource = dt;
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Tên like '%{0}%' ", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestCRP testCRP = new TestCRP();
            testCRP.Show();

        }
    }
}
