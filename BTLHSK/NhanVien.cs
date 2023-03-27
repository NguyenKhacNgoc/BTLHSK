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
        string str = "Data Source=KHACNGOC;Initial Catalog=ThietBiMayTinh;Integrated Security=True";
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
            using (SqlConnection cnn = new SqlConnection(str))
            {
                cnn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("select * from v_NV", cnn))
                {
                    DataTable tb = new DataTable();
                    da.Fill(tb);
                    dataGridViewNV.DataSource = tb;
                    dataGridViewNV.AutoResizeColumns();
                    dataGridViewNV.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;


                }

            }
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
                tbMaNV.Text = dataGridViewNV.CurrentRow.Cells["Mã NV"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemNV";
                cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
                cmd.Parameters.AddWithValue("@Ten", tbTen.Text);
                cmd.Parameters.AddWithValue("@SDT", tbSDT.Text);
                if (cmd.ExecuteNonQuery() > 0) HienNV(sender, e);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaTenNV";
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
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaNV";
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
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from v_NV", cnn);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dataGridViewNV.DataSource = dataTable;
                DataView dv = new DataView(dataTable);
                dv.RowFilter = string.Format("[Tên] LIKE '%{0}%'", tbTen.Text);
                dataGridViewNV.DataSource = dv;



            }catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbMaNV_Validating(object sender, CancelEventArgs e)
        {
            int MaNV;
            bool result = int.TryParse(tbMaNV.Text, out MaNV);
            if (result && !string.IsNullOrEmpty(tbMaNV.Text))
            {
                errorProviderMaNV.SetError(tbMaNV, "");
            }
            else
            {
                errorProviderMaNV.SetError(tbMaNV, "Mã nhân viên là số và không được bỏ trống");
            }
        }

        private void tbTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTen.Text))
            {
                errorProviderTen.SetError(tbTen, "Không bỏ trống");
            }
            else errorProviderTen.SetError(tbTen, "");
        }

        private void tbSDT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSDT.Text))
            {
                errorProviderTen.SetError(tbSDT, "Không bỏ trống");
            }
            else errorProviderTen.SetError(tbSDT, "");

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhanVien_Load(sender, e);
        }
    }
}
