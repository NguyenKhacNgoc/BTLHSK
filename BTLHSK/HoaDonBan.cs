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
        string str = "Data Source=KHACNGOC;Initial Catalog=ThietBiMayTinh;Integrated Security=True";
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
            using (SqlConnection cnn = new SqlConnection(str))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select sTen from tblNhanVien", cnn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while(rdr.Read())
                        {
                            cbTenNV.Items.Add(rdr["sTen"].ToString());
                        }
                    }

                }
            }
        }
        private void HienHoaDonBan (object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(str)){
                cnn.Open();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from v_HDB", cnn))
                {
                    DataTable dataTable= new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewHDB.DataSource = dataTable;
                    dataGridViewHDB.AutoResizeColumns();
                    dataGridViewHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    cnn.Open();
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "ThemHoaDonBan";
                        cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                        cmd.Parameters.AddWithValue("@TenNV", cbTenNV.Text);
                        cmd.Parameters.AddWithValue("@NgayTao", dateTimePickerNgayTao.Text);
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) HienHoaDonBan(sender, e);
                    }



                }

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
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    cnn.Open();
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SuaHoaDonBan";
                        cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                        
                        cmd.Parameters.AddWithValue("@NgayTao", dateTimePickerNgayTao.Text);
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) HienHoaDonBan(sender, e);
                    }



                }

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
                int MaHD = Convert.ToInt32(tbMaHD.Text);
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    cnn.Open();
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "XoaHoaDonBan";
                        cmd.Parameters.AddWithValue("@MaHD", MaHD);
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) HienHoaDonBan(sender, e);

                    }



                }

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
                int MaHD = Convert.ToInt32(tbMaHD.Text);
                if (string.IsNullOrEmpty(tbMaHD.Text))
                {
                    HienHoaDonBan(sender, e);

                }
                else
                {

                    using (SqlConnection cnn = new SqlConnection(str))
                    {
                        using (SqlCommand cmd = new SqlCommand("select * from v_HDB", cnn))
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                DataTable tb = new DataTable();
                                da.Fill(tb);
                                dataGridViewHDB.DataSource = tb;

                                DataView dv = new DataView(tb);
                                dv.RowFilter = string.Format("[Mã Hoá Đơn] = '{0}'", MaHD);
                                dataGridViewHDB.DataSource = dv;


                            }

                        }
                    }

                }

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

        private void tbMaHD_Validating(object sender, CancelEventArgs e)
        {
            int MaHD;
            bool result = int.TryParse(tbMaHD.Text, out MaHD);
            
            if (result)
            {
                errorProviderMaHD.SetError(tbMaHD, "");
            }
            else
            {
                errorProviderMaHD.SetError(tbMaHD, "Mã Hoá Đơn là số nguyên");

            }
            
            
        }

        private void cbMaNV_Validating(object sender, CancelEventArgs e)
        {
            if (cbTenNV.Text == "")
            {
                errorProviderMaNV.SetError(cbTenNV, "Không được để trống");

            }
            else errorProviderMaNV.SetError(cbTenNV, "");
        }

        private void btnXemCT_Click_1(object sender, EventArgs e)
        {
            int MaHD = (int)dataGridViewHDB.SelectedRows[0].Cells["Mã Hoá Đơn"].Value;
            CTHoaDonBan xem = new CTHoaDonBan(MaHD);
            xem.XemCTHDB(MaHD);
            xem.ShowDialog();
           
            


        }
    }
}
