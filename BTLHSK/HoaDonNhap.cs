﻿using System;
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
            sql sql = new sql();
            sql.combobox("select iMaNV from tblNhanVien", "iMaNV", cbNV);

        }
        
        private void HienHDN(object sender, EventArgs e)
        {
            sql sql = new sql();
            DataTable dt = sql.getDB("select * from v_HoaDonNhap");
            dataGridViewHDN.DataSource = dt;
            dataGridViewHDN.AutoResizeColumns();
            dataGridViewHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("insert into tblHoaDonNhap (iMaHD, iMaNV, sNCC, dNgayTao) values (@MaHD, @MaNV, @NCC, @NgayTao)");
                cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                cmd.Parameters.AddWithValue("@MaNV", cbNV.Text);
                cmd.Parameters.AddWithValue("@NCC", tbNCC.Text);
                cmd.Parameters.AddWithValue("@NgayTao", Convert.ToDateTime(dateTimePickerNT.Text));
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
                sql sql = new sql();
                sql.ketnoi();
                SqlCommand cmd = sql.EDIT("update tblHoaDonNhap set sNCC = @NCC where iMaHD = @MaHD and iMaNV = @MaNV");
                cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                cmd.Parameters.AddWithValue("@MaNV", cbNV.Text);
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
                sql sql = new sql();
                SqlCommand cmd = sql.EDIT("delete tblHoaDonNhap where iMaHD = @MaHD AND iMaNV = @MaNV");
                cmd.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                cmd.Parameters.AddWithValue("@MaNV", cbNV.Text);
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
                cbNV.Text = dataGridViewHDN.CurrentRow.Cells["Tên nhân viên"].Value.ToString();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                
                sql sql = new sql();
                DataTable dt = sql.getDB("select * from v_HoaDonNhap");
                dataGridViewHDN.DataSource = dt;
                DataView dv = new DataView(dt);
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
            try
            {
                int MaHD = (int)dataGridViewHDN.SelectedRows[0].Cells["Mã hoá đơn"].Value;
                CTHoaDonNhap xemct = new CTHoaDonNhap(MaHD);
                xemct.XemCTHD(MaHD);
                xemct.Show();

            }
            catch
            {
                MessageBox.Show("Hãy chọn hoá đơn để xem chi tiết", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }

    }
}
