using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Application.Exit();
            }
        }

        private void mnHDB_Click(object sender, EventArgs e)
        {
            HoaDonBan HoaDonBan = new HoaDonBan();
            HoaDonBan.MdiParent = this;
            HoaDonBan.Show();
        }
    }
}
