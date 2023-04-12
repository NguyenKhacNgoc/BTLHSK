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
    public partial class CTHoaDonNhap : Form
    {

        private int MaHD;
        public CTHoaDonNhap(int MaHD)
        {
            this.MaHD = MaHD;
            
            InitializeComponent();
        }
        public void XemCTHD(int MaHD)
        {
            sql sql = new sql();
            DataTable dt = sql.getDB("select * from v_CTHDN");
            dataGridViewCTHDN.DataSource = dt;
            dataGridViewCTHDN.AutoResizeColumns();
            dataGridViewCTHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("[Mã hoá đơn] = '{0}'", MaHD);
            dataGridViewCTHDN.DataSource = dv;

            
        }

        private void CTHoaDonNhap_Load(object sender, EventArgs e)
        {
            CBHD(sender, e);
            CBMH(sender, e);
            HienCT(sender, e);
            XemCTHD(MaHD);
            
            

        }
        
        private void CBHD(object sender, EventArgs e)
        {
            sql sql = new sql();
            sql.combobox("select iMaHD from tblHoaDonNhap", "iMaHD", cbMaHD);
   

        }
        private void CBMH(object sender, EventArgs e)
        {
            sql sql = new sql();
            sql.combobox("select iMaMH from tblMatHang", "iMaMH", cbMaMH);
        }
        private void HienCT(object sender, EventArgs e)
        {
            sql sql = new sql();
            DataTable dt = sql.getDB("select * from v_CTHDN");
            dataGridViewCTHDN.DataSource = dt;
            dataGridViewCTHDN.AutoResizeColumns();
            dataGridViewCTHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sql sql = new sql();
            SqlCommand cmd = sql.EDIT("delete tblCTHoaDonNhap where iMaHD = @MaHD and iMaMH = @MaMH ");
            cmd.Parameters.AddWithValue("@MaHD", cbMaHD.Text);
            cmd.Parameters.AddWithValue("@MaMH", cbMaMH.Text);
            if(cmd.ExecuteNonQuery() > 0) HienCT(sender, e); 
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
         
            try
            {
                sql sql = new sql();
                sql.ketnoi();
                SqlCommand cmd = sql.EDIT("insert into tblCTHoaDonNhap(iMaHD, iMaMH, iSoLuong, fDonGia) values(@MaHD, @MaMH, @SL, @DG)");
                cmd.Parameters.AddWithValue("@MaHD", cbMaHD.Text);
                cmd.Parameters.AddWithValue("@MaMH", cbMaMH.Text);
                cmd.Parameters.AddWithValue("@SL", tbSL.Text);
                cmd.Parameters.AddWithValue("@DG", tbDG.Text);
                if (cmd.ExecuteNonQuery() > 0) HienCT(sender, e);

            }
            catch
            {
                MessageBox.Show("Đã có lỗi, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void dataGridViewCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                cbMaHD.Text = dataGridViewCTHDN.CurrentRow.Cells["Mã hoá đơn"].Value.ToString();
                cbMaMH.Text = dataGridViewCTHDN.CurrentRow.Cells["Mã mặt hàng"].Value.ToString();
        }

        

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                DataTable dt = sql.getDB("select * from v_CTHDN");
                dataGridViewCTHDN.DataSource = dt;
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("[Mã hoá đơn] = '{0}'", cbMaHD.Text);
                dataGridViewCTHDN.DataSource = dv;

            }
            catch
            {
                MessageBox.Show("Đã có lỗi, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void btnXem_Click(object sender, EventArgs e)
        {
            HienCT(sender, e);
        }
    }
}
