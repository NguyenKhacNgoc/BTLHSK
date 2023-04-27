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
    public partial class CTHoaDonBan : Form
    {

        private int MaHD;
       
        public CTHoaDonBan(int MaHD)
        {
            InitializeComponent();
            this.MaHD = MaHD;
            
            
        }

        private void CTHoaDonBan_Load(object sender, EventArgs e)
        {
         
            HienCBBoxMaHD();
            HienCBBoxMaMH(); 
            HienDTGRV();
            XemCTHDB(MaHD);
        }
        private void HienCBBoxMaHD()
        {
            sql sql = new sql();
            sql.combobox("select iMaHD from tblHoaDonBan", "iMaHD", cbMaHD);
            
        }

        private void HienCBBoxMaMH()
        {
            sql sql = new sql();
            sql.combobox("select iMaMH from tblMatHang", "iMaMH", cbMaMH);
        }

       private void HienDTGRV()
        {
            sql sql = new sql();
            DataTable dt = sql.getDB("select * from v_CTHDB");
            dataGridViewCTHDB.DataSource = dt;
            dataGridViewCTHDB.AutoResizeColumns();
            dataGridViewCTHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(tbSL.Text) <= 0)
                {
                    errorProviderSL.SetError(tbSL, "Số lượng phải lớn hơn 0");
                }
                if(Convert.ToInt32(tbSL.Text) > 0)
                {
                    errorProviderSL.SetError(tbSL, "");
                }
                if(Convert.ToInt32(tbGB.Text) <= 0)
                {
                    errorProviderGB.SetError(tbGB, "Giá bán phải phải lớn hơn 0");
                }
                if(Convert.ToInt32(tbGB.Text) > 0)
                {
                    errorProviderGB.SetError(tbGB, "");
                }
                
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("INSERT INTO dbo.tblCTHoaDonBan(iMaHD,iMaMH,iSoLuong,fGiaBan,iThoiGianBaoHanh,sGhiChu) VALUES (@MaHD, @MaMH, @SoLuong, @GiaBan, @TGBH, @GhiChu)");
                cmd.Parameters.AddWithValue("@MaHD", cbMaHD.Text);
                cmd.Parameters.AddWithValue("@MaMH", cbMaMH.Text);
                cmd.Parameters.AddWithValue("@SoLuong", tbSL.Text);
                cmd.Parameters.AddWithValue("@GiaBan", tbGB.Text);
                cmd.Parameters.AddWithValue("@TGBH", tbTGBH.Text);
                cmd.Parameters.AddWithValue("@GhiChu", tbGC.Text);
                if (cmd.ExecuteNonQuery() > 0) HienDTGRV();

            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi trong quá trình thên dữ liệu, vui lòng xem lại", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

            
        }

        private void dataGridViewCTHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                cbMaHD.Text = dataGridViewCTHDB.CurrentRow.Cells["Mã HD"].Value.ToString();
                cbMaMH.Text = dataGridViewCTHDB.CurrentRow.Cells["Mã MH"].Value.ToString();
        }

        

       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("DELETE dbo.tblCTHoaDonBan WHERE iMaHD = @MaHD AND iMaMH = @MaMH");
                cmd.Parameters.AddWithValue("@MaHD", cbMaHD.Text);
                cmd.Parameters.AddWithValue("@MaMH", cbMaMH.Text);
                if (cmd.ExecuteNonQuery() > 0) HienDTGRV();
            }catch
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                DataTable dt = sql.getDB("select * from v_CTHDB");
                dataGridViewCTHDB.DataSource = dt;
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("[Mã HD] = '{0}'", cbMaHD.Text);
                dataGridViewCTHDB.DataSource = dv;
  
            }catch
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            /*
             SqlConnection cnn = new SqlConnection(str);
             cnn.Open();
             string sql = "exec xemTTHH @MaHD, @MaMH";
             SqlCommand cmd = new SqlCommand(sql, cnn);
             cmd.Parameters.AddWithValue("@MaHD", cbMaHD.Text);
             cmd.Parameters.AddWithValue("@MaMH", cbMaMH.Text);
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
             dataGridViewCTHDB.DataSource = dt;

            */
            HienDTGRV();
            
        }
        public void XemCTHDB(int MaHD)
        {
            sql sql = new sql();
            DataTable dt = sql.getDB("select * from v_CTHDB");
            dataGridViewCTHDB.DataSource = dt;
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("[Mã HD] = '{0}'", MaHD);
            dataGridViewCTHDB.DataSource = dv;

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int MaHD = (int)dataGridViewCTHDB.SelectedRows[0].Cells[0].Value;
            RP_CTHDB rp = new RP_CTHDB(MaHD);
            rp.void_RP_CT_HDB(MaHD);
            rp.ShowDialog();

        }
    }
    
}
