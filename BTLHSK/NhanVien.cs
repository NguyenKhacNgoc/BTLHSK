using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            sql sql = new sql();
            DataTable dt = sql.getDB("select * from v_NV");
            dataGridViewNV.DataSource = dt;
            dataGridViewNV.AutoResizeColumns();
            dataGridViewNV.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
          
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
                tbMaNV.Text = dataGridViewNV.CurrentRow.Cells["Mã NV"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("INSERT INTO tblNhanVien(iMaNV, sTen, sSDT) VALUES(@MaNV, @Ten, @SDT)");
                cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
                cmd.Parameters.AddWithValue("@Ten", tbTen.Text);
                cmd.Parameters.AddWithValue("@SDT", tbSDT.Text);
                if (cmd.ExecuteNonQuery() > 0) HienNV(sender, e);
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("UPDATE dbo.tblNhanVien SET sTen = @Ten WHERE iMaNV = @MaNV");
                cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
                cmd.Parameters.AddWithValue("@Ten", tbTen.Text);
                
                if (cmd.ExecuteNonQuery() > 0) HienNV(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("DELETE dbo.tblNhanVien WHERE iMaNV = @MaNV");
                cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
                if (cmd.ExecuteNonQuery() > 0) HienNV(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                DataTable dt = sql.getDB("select * from v_NV");
                dataGridViewNV.DataSource = dt;
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("[Tên] LIKE '%{0}%'", tbTen.Text);
                dataGridViewNV.DataSource = dv;



            }catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       

        

   
    }
}
