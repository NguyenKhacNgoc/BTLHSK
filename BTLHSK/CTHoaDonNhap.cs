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
        
        
        string str = "Data Source=KHACNGOC;Initial Catalog=ThietBiMayTinh;Integrated Security=True";
        public CTHoaDonNhap()
        {
            
            InitializeComponent();
        }

        

        private void CTHoaDonNhap_Load(object sender, EventArgs e)
        {
            CBHD(sender, e);
            CBMH(sender, e);
            HienCT(sender, e);
            
            

        }
        private void xemCT(object sender, EventArgs e)
        {
            
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("exec xemCT @MaHD", cnn);
            cmd.Parameters.AddWithValue("@MaHD", cbMaHD.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewCTHDN.DataSource = dt;
        }
        private void CBHD(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd1 = new SqlCommand("select iMaHD FROM tblHoaDonNhap ", cnn);
            SqlDataReader sqlDataReader1 = cmd1.ExecuteReader();
            while(sqlDataReader1.Read())
            {
                cbMaHD.Items.Add(sqlDataReader1["iMaHD"].ToString());

            }
            
            


        }
        private void CBMH(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("select iMaMH from tblMatHang ", cnn);
            SqlDataReader sqlDataReader2 = cmd2.ExecuteReader();
            while(sqlDataReader2.Read())
            {
                cbMaMH.Items.Add(sqlDataReader2["iMaMH"].ToString());

            }
        }
        private void HienCT(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from v_CTHDN", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewCTHDN.DataSource = dt;
            dataGridViewCTHDN.AutoResizeColumns();
            dataGridViewCTHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("delete tblCTHoaDonNhap where iMaHD = @MaHD and iMaMH = @MaMH ", cnn);
            cmd.Parameters.AddWithValue("@MaHD", cbMaHD.Text);
            cmd.Parameters.AddWithValue("@MaMH", cbMaMH.Text);
            if(cmd.ExecuteNonQuery() > 0) HienCT(sender, e); 
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int DG;
            bool result = int.TryParse(tbDG.Text, out DG);
            if (result && Convert.ToInt32(tbDG.Text) > 0) errorProviderDG.SetError(tbDG, "");
            else errorProviderDG.SetError(tbDG, "Đơn giá là số nguyên dương");
            int SL;
            bool result_sl = int.TryParse(tbSL.Text, out SL);
            if (result_sl && Convert.ToInt32(tbSL.Text) > 0) errorProviderSL.SetError(tbSL, "");
            else errorProviderSL.SetError(tbSL, "Số lượng là số nguyên dương");
            try
            {
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into tblCTHoaDonNhap(iMaHD, iMaMH, iSoLuong, fDonGia) values(@MaHD, @MaMH, @SL, @DG)", cnn);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("update tblCTHoaDonNhap set iSoLuong = @SL where iMaHD = @MaHD AND iMaMH = @MaMH", cnn);
                cmd.Parameters.AddWithValue("@MaHD", cbMaHD.Text);
                cmd.Parameters.AddWithValue("@MaMH", cbMaMH.Text);
                cmd.Parameters.AddWithValue("@SL", tbSL.Text);
                if (cmd.ExecuteNonQuery() > 0) HienCT(sender, e);

            }
            catch
            {
                MessageBox.Show("Đã có lỗi, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from v_CTHDN", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
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

       

        
    }
}
