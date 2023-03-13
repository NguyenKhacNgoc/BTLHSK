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
            ComboboxMaNV();
            HienHoaDonBan(sender, e);
            

        }
        private void ComboboxMaNV()
        {
            using (SqlConnection cnn = new SqlConnection(str))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select iMaNV from tblNhanVien", cnn))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while(rdr.Read())
                        {
                            cbMaNV.Items.Add(rdr["iMaNV"].ToString());
                        }
                    }

                }
            }
        }
        private void HienHoaDonBan (object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(str)){
                cnn.Open();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from tblHoaDonBan", cnn))
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
            int MaHD = Convert.ToInt32(tbMaHD.Text);
            int MaNV = Convert.ToInt32(cbMaNV.Text);
            DateTime NgayTao = Convert.ToDateTime(dateTimePickerNgayTao.Text);
            using (SqlConnection cnn = new SqlConnection(str))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ThemHoaDonBan";
                    cmd.Parameters.AddWithValue("@MaHD", MaHD);
                    cmd.Parameters.AddWithValue("@MaNV", MaNV);
                    cmd.Parameters.AddWithValue("@NgayTao",NgayTao);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) HienHoaDonBan(sender, e);
                }
                

                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int MaHD = Convert.ToInt32(tbMaHD.Text);
            int MaNV = Convert.ToInt32(cbMaNV.Text);
            DateTime NgayTao = Convert.ToDateTime(dateTimePickerNgayTao.Text);
            using (SqlConnection cnn = new SqlConnection(str))
            {
                cnn.Open();
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SuaHoaDonBan";
                    cmd.Parameters.AddWithValue("@MaHD", MaHD);
                    cmd.Parameters.AddWithValue("@MaNV", MaNV);
                    cmd.Parameters.AddWithValue("@NgayTao", NgayTao);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) HienHoaDonBan(sender, e);
                }



            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
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

        private void btnTK_Click(object sender, EventArgs e)
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
                    using (SqlCommand cmd = new SqlCommand("select * from tblHoaDonBan", cnn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable tb = new DataTable();
                            da.Fill(tb);
                            dataGridViewHDB.DataSource = tb;

                            DataView dv = new DataView(tb);
                            dv.RowFilter = string.Format("iMaHD = '{0}'", MaHD);
                            dataGridViewHDB.DataSource = dv;

                        }

                    }
                }
            }
            
        }
    }
}
