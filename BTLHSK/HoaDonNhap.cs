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
    public partial class HoaDonNhap : Form
    {
        
        string str = "Data Source=KHACNGOC;Initial Catalog=ThietBiMayTinh;Integrated Security=True";
        

        public HoaDonNhap()
        {
            
            InitializeComponent();
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            CB(sender, e);
            HienHDN(sender, e);

        }
        private void CB(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select sTen from tblNhanVien", cnn);
            SqlDataReader dataReader= cmd.ExecuteReader();
            while(dataReader.Read())
            {
                cbTenNV.Items.Add(dataReader["sTen"].ToString());
            }

        }
        
        private void HienHDN(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from v_HoaDonNhap", cnn);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridViewHDN.DataSource = dataTable;
            dataGridViewHDN.AutoResizeColumns();
            dataGridViewHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaHD.Text)) errorProviderMaHD.SetError(tbMaHD, "Không bỏ trống");
            else errorProviderMaHD.SetError(tbMaHD, "");
            if (string.IsNullOrEmpty(cbTenNV.Text)) errorProviderMaNV.SetError(cbMaNV, "Không bỏ trống");
            else errorProviderMaNV.SetError(cbTenNV, "");
            if (string.IsNullOrEmpty(tbNCC.Text)) errorProviderNCC.SetError(tbNCC, "Không bỏ trống");
            else errorProviderNCC.SetError(tbNCC, "");
            try
            {
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into tblHoaDonNhap (iMaHD, sTenNV, sNCC, dNgayTao) values (@MaHD, @TenNV, @NCC, @NgayTao)", cnn);
                cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                cmd.Parameters.AddWithValue("@TenNV", cbTenNV.Text);
                cmd.Parameters.AddWithValue("@NCC", tbNCC.Text);
                cmd.Parameters.AddWithValue("@NgayTao", dateTimePickerNT.Text);
                if (cmd.ExecuteNonQuery() > 0) HienHDN(sender, e);
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
                SqlCommand cmd = new SqlCommand("update tblHoaDonNhap set sNCC = @NCC where iMaHD = @MaHD and sTenNV = @TenNV", cnn);
                cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                cmd.Parameters.AddWithValue("@TenNV", cbTenNV.Text);
                cmd.Parameters.AddWithValue("@NCC", tbNCC.Text);
                if (cmd.ExecuteNonQuery() > 0) HienHDN(sender, e);

            }catch(Exception ex)
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
                SqlCommand cmd = new SqlCommand("delete tblHoaDonNhap where iMaHD = @MaHD AND sTenNV = @TenNV", cnn);
                cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                cmd.Parameters.AddWithValue("@TenNV", cbTenNV.Text);
                if(cmd.ExecuteNonQuery() > 0) HienHDN(sender,e);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                tbMaHD.Text = dataGridViewHDN.CurrentRow.Cells["Mã hoá đơn"].Value.ToString();
                cbTenNV.Text = dataGridViewHDN.CurrentRow.Cells["Tên nhân viên"].Value.ToString();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(str);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from v_HoaDonNhap", cnn);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dataGridViewHDN.DataSource= dataTable;
                DataView dv = new DataView(dataTable);
                dv.RowFilter = string.Format("[Nhà cung cấp] like '%{0}%'", tbNCC.Text);
                dataGridViewHDN.DataSource = dv;

            }
            catch
            {
                MessageBox.Show("Đã có lỗi, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        private void btnXemCT_Click_1(object sender, EventArgs e)
        {
            
            
            

        }
        
    }
}
