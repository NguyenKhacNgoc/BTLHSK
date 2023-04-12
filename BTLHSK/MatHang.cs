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
    public partial class MatHang : Form
    {
        public MatHang()
        {
            InitializeComponent();
        }

        private void MatHang_Load(object sender, EventArgs e)
        {
            HienMH(sender, e);
           

        }
        
        private void HienMH(object sender, EventArgs e)
        {
            sql sql = new sql();
            DataTable dt = sql.getDB("select * from v_MatHang");
            dataGridViewMH.DataSource = dt;
            dataGridViewMH.AutoResizeColumns();
            dataGridViewMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                string them = "insert into tblMatHang(iMaMH, sTenLH, sMauSac) values(@MaMH, @TenLH, @MauSac)";
                SqlCommand cmd = sql.EDIT(them);
                cmd.Parameters.AddWithValue("@MaMH", tbMaMH.Text);
                cmd.Parameters.AddWithValue("@TenLH", tbTenLH.Text);
                cmd.Parameters.AddWithValue("@MauSac", tbMS.Text);
                if(cmd.ExecuteNonQuery() > 0) HienMH(sender, e);

            }catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                string sua = "update tblMatHang set sTenLH = @TenLH where iMaMH = @MaMH";
                SqlCommand cmd = sql.EDIT(sua);
                cmd.Parameters.AddWithValue("@MaMH", tbMaMH.Text);
                cmd.Parameters.AddWithValue("@TenLH", tbTenLH.Text);
                if (cmd.ExecuteNonQuery() > 0) HienMH(sender, e);

            }
            catch
            {
                MessageBox.Show("Đã có lỗi, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("delete tblMatHang where iMaMH = @MaMH");
                cmd.Parameters.AddWithValue("@MaMH", tbMaMH.Text);
                if (cmd.ExecuteNonQuery() > 0) HienMH(sender, e);


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
                sql sql = new sql();
                DataTable dt = sql.getDB("select * from v_MatHang");
                dataGridViewMH.DataSource = dt;
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("[Tên loại hàng] like '%{0}%'", tbTenLH.Text);
                dataGridViewMH.DataSource = dv;


            }
            catch
            {
                MessageBox.Show("Đã có lỗi, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            MatHang_Load(sender, e);
        }

        private void dataGridViewMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                tbMaMH.Text = dataGridViewMH.CurrentRow.Cells["Mã mặt hàng"].Value.ToString();
        }
    }
}
