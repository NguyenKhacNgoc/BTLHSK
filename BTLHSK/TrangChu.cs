using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BTLHSK
{
    public partial class TrangChu : Form
    {
        

        public TrangChu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnNV_Click(object sender, EventArgs e)
        {
            NhanVien form2 = new NhanVien();
            form2.MdiParent= this;
            form2.Show();
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chứ", "Đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void mnHDB_Click(object sender, EventArgs e)
        {
            HoaDonBan HoaDonBan = new HoaDonBan();
            HoaDonBan.MdiParent = this;
            HoaDonBan.Show();
        }

        private void mnCTHDB_Click(object sender, EventArgs e)
        {
            CTHoaDonBan CTHoaDonBan = new CTHoaDonBan(0);
            CTHoaDonBan.MdiParent= this;
            CTHoaDonBan.Show();
        }

        

        private void mnMH_Click(object sender, EventArgs e)
        {
            MatHang mathang = new MatHang();
            mathang.MdiParent = this;
            mathang.Show();
        }

        private void mnHDN_Click(object sender, EventArgs e)
        {
            HoaDonNhap hoaDonNhap= new HoaDonNhap();
            hoaDonNhap.MdiParent = this;
            hoaDonNhap.Show();
        }

        private void mnCTHDN_Click(object sender, EventArgs e)
        {
            CTHoaDonNhap cTHoaDonNhap = new CTHoaDonNhap();
            cTHoaDonNhap.MdiParent = this;
            cTHoaDonNhap.Show();
        }
    }
}
