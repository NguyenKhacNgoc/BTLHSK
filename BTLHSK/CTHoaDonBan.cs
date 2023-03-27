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
        public string str = "Data Source=KHACNGOC;Initial Catalog=ThietBiMayTinh;Integrated Security=True";
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
            using(SqlConnection cnn = new SqlConnection(str))
            {
                cnn.Open();
                using(SqlCommand cmd = new SqlCommand("select iMaHD from tblHoaDonBan", cnn))
                {
                    using(SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while(rdr.Read())
                        {
                            cbMaHD.Items.Add(rdr["iMaHD"].ToString());
                        }
                    }
                    
                    

                    
                }
            }
        }

        private void HienCBBoxMaMH()
        {
            using (SqlConnection cnn = new SqlConnection(str))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select iMaMH from tblMatHang", cnn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            cbMaMH.Items.Add(rdr["iMaMH"].ToString());
                        }
                    }




                }
            }
        }

       private void HienDTGRV()
        {
            using (SqlConnection cnn = new SqlConnection(str))
            {
                cnn.Open();
                using(SqlDataAdapter da = new SqlDataAdapter("select * from v_CTHDB", cnn))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    dataGridViewCTHDB.DataSource = dataTable;
                    dataGridViewCTHDB.AutoResizeColumns();
                    dataGridViewCTHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                

                
            }
        }


        

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int MaHD = Convert.ToInt32(cbMaHD.Text);
                int MaMH = Convert.ToInt32(cbMaMH.Text);
                int SoLuong = Convert.ToInt32(tbSL.Text);
                int TGBH = Convert.ToInt32(tbTGBH.Text);
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    cnn.Open();
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "ThemCTHDB";
                        cmd.Parameters.AddWithValue("@MaHD", MaHD);
                        cmd.Parameters.AddWithValue("@MaMH", MaMH);
                        cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
                        cmd.Parameters.AddWithValue("@GiaBan", tbGB.Text);
                        cmd.Parameters.AddWithValue("@TGBH", TGBH);
                        cmd.Parameters.AddWithValue("@GhiChu", tbGC.Text);
                        if (cmd.ExecuteNonQuery() > 0) HienDTGRV();

                    }
                }

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection cnn = new SqlConnection(str))
                {
                    cnn.Open();
                    using(SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SuaCTHDB";
                        cmd.Parameters.AddWithValue("@MaHD", cbMaHD.Text);
                        cmd.Parameters.AddWithValue("@MaMH", cbMaMH.Text);
                        cmd.Parameters.AddWithValue("@SoLuong", tbSL.Text);
                        cmd.Parameters.AddWithValue("@GiaBan", tbGB.Text);
                        cmd.Parameters.AddWithValue("@TGBH", tbTGBH.Text);
                        cmd.Parameters.AddWithValue("@GhiChu", tbGC.Text);
                        if (cmd.ExecuteNonQuery() > 0) HienDTGRV();
                    }
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSL_Validating(object sender, CancelEventArgs e)
        {
            int SoLuong;
            bool result_sl = int.TryParse(tbSL.Text, out SoLuong);
            if (result_sl && Convert.ToInt32(tbSL.Text)>0)
            {
                // nếu giá trị nhập vào là số nguyên và >0
                errorProviderSL.SetError(tbSL, "");
                
            }
            else
            {
                errorProviderSL.SetError(tbSL, "Số lượng phải là số nguyên và lớn hơn 0");
                
            }
            
                
        }

        private void tbTGBH_Validating(object sender, CancelEventArgs e)
        {
            int tgbh;
            bool result_tgbh = int.TryParse(tbTGBH.Text, out tgbh);
            if (result_tgbh && Convert.ToInt32(tbTGBH.Text) > 0)
            {
                errorProviderTGBH.SetError(tbTGBH, "");

            }
            else
            {
                errorProviderTGBH.SetError(tbTGBH, "Đây là số tháng bảo hành");

            }


        }
        private void tbGB_Validating(object sender, CancelEventArgs e)
        {
            int gb;
            bool result = int.TryParse(tbTGBH.Text, out gb);
            if (result && Convert.ToInt32(tbGB.Text) > 0)
            {
                errorProviderGB.SetError(tbGB, "");

            }
            else
            {
                errorProviderGB.SetError(tbGB, "Đây là số tháng bảo hành");

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    cnn.Open();
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "XoaCTHDB";
                        cmd.Parameters.AddWithValue("@MaHD", cbMaHD.Text);
                        cmd.Parameters.AddWithValue("@MaMH", cbMaMH.Text);
                        if (cmd.ExecuteNonQuery() > 0) HienDTGRV();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng xem lại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbMaHD.Text))
                {
                    HienDTGRV();
                }
                else
                {
                    SqlConnection cnn = new SqlConnection(str);
                    cnn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from v_CTHDB", cnn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewCTHDB.DataSource = dataTable;

                    DataView dataView = new DataView(dataTable);
                    dataView.RowFilter = string.Format("[Mã HD] = '{0}'", cbMaHD.Text);
                    dataGridViewCTHDB.DataSource = dataView;

                }
                

            }catch(Exception ex)
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
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("exec xemCTHDB @MaHD", cnn);
            cmd.Parameters.AddWithValue("@MaHD", MaHD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewCTHDB.DataSource = dt;

        }
        

        
    }
    
}
