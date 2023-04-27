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
    public partial class HoaDonBan : Form
    {
        public HoaDonBan()
        {
            InitializeComponent();
        }

        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            ComboboxTenNV();
            HienHoaDonBan(sender, e);
            

        }
       
        private void ComboboxTenNV()
        {
            sql sql = new sql();
            sql.combobox("select iMaNV from tblNhanVien", "iMaNV", cbNV);
        }
        private void HienHoaDonBan (object sender, EventArgs e)
        {
            sql sql = new sql();
            DataTable dt = sql.getDB("Select * from v_HDB");
            dataGridViewHDB.DataSource = dt;
            dataGridViewHDB.AutoResizeColumns();
            dataGridViewHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("INSERT INTO dbo.tblHoaDonBan(iMaHD,iMaNV,dNgayTao) VALUES(@MaHD, @MaNV, @NgayTao)");
                cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                cmd.Parameters.AddWithValue("@MaNV", cbNV.Text);
                cmd.Parameters.AddWithValue("@NgayTao", Convert.ToDateTime(dateTimePickerNgayTao.Text));
                int i = cmd.ExecuteNonQuery();
                if (i > 0) HienHoaDonBan(sender, e);
            }
            catch
            {
                MessageBox.Show("Đã có lỗi trong quá trình thên dữ liệu, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("UPDATE dbo.tblHoaDonBan SET dNgayTao = @NgayTao WHERE iMaHD = @MaHD");
                cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                cmd.Parameters.AddWithValue("@NgayTao", dateTimePickerNgayTao.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0) HienHoaDonBan(sender, e);
            }
            catch
            {
                MessageBox.Show("Đã có lỗi trong quá trình sửa dữ liệu, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("DELETE dbo.tblHoaDonBan WHERE iMaHD = @MaHD");
                cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0) HienHoaDonBan(sender, e);
            }
            catch
            {
                MessageBox.Show("Đã có lỗi trong quá trình xoá dữ liệu, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            
            try
            {
                sql sql = new sql();
                DataTable dt = sql.getDB("select * from v_HDB");
                dataGridViewHDB.DataSource = dt;
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("[Mã Hoá Đơn] = '{0}'", tbMaHD.Text);
                dataGridViewHDB.DataSource = dv;
                

            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

       

        private void dataGridViewHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                tbMaHD.Text = dataGridViewHDB.CurrentRow.Cells["Mã Hoá Đơn"].Value.ToString();
        }

        private void btnXemCT_Click_1(object sender, EventArgs e)
        {
            try
            {
                int MaHD = (int)dataGridViewHDB.SelectedRows[0].Cells["Mã Hoá Đơn"].Value;
                CTHoaDonBan xem = new CTHoaDonBan(MaHD);
                xem.XemCTHDB(MaHD);
                xem.Show();

            }
            catch
            {
                MessageBox.Show("Hãy chọn hoá đơn để xem chi tiết", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }


    }
}
