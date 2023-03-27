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
        string str = "Data Source=KHACNGOC;Initial Catalog=ThietBiMayTinh;Integrated Security=True";
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
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from v_MatHang", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMH.DataSource = dt;
            dataGridViewMH.AutoResizeColumns();
            dataGridViewMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                string them = "insert into tblMatHang(iMaMH, sTenLH, sMauSac) values(@MaMH, @TenLH, @MauSac)";
                SqlCommand cmd = new SqlCommand(them, cnn);
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
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                string sql = "update tblMatHang set sTenLH = @TenLH where iMaMH = @MaMH";
                SqlCommand cmd = new SqlCommand(sql, cnn);
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
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("delete tblMatHang where iMaMH = @MaMH", cnn);
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
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from v_MatHang", cnn);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dataGridViewMH.DataSource = dataTable;
                DataView dv = new DataView(dataTable);
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

        private void tbMaMH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaMH.Text))
            {
                errorProviderMaMH.SetError(tbMaMH, "Không được bỏ trống");
            }
            else errorProviderMaMH.SetError(tbMaMH, "");



        }

        private void tbTenLH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenLH.Text))
            {
                errorProviderMaMH.SetError(tbTenLH, "Không được bỏ trống");
            }
            else errorProviderMaMH.SetError(tbTenLH, "");
        }

        private void tbMS_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMS.Text))
            {
                errorProviderMaMH.SetError(tbMS, "Không được bỏ trống");
            }
            else errorProviderMaMH.SetError(tbMS, "");
        }

        

        

        private void dataGridViewMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                tbMaMH.Text = dataGridViewMH.CurrentRow.Cells["Mã mặt hàng"].Value.ToString();
        }
    }
}
