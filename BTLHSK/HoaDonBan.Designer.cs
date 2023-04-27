namespace BTLHSK
{
    partial class HoaDonBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbNgayTao = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayTao = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewHDB = new System.Windows.Forms.DataGridView();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnXemCT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(12, 24);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(82, 16);
            this.lbMaHD.TabIndex = 0;
            this.lbMaHD.Text = "Mã Hoá Đơn";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(250, 24);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(86, 16);
            this.lbTenNV.TabIndex = 1;
            this.lbTenNV.Text = "Mã nhân viên";
            // 
            // lbNgayTao
            // 
            this.lbNgayTao.AutoSize = true;
            this.lbNgayTao.Location = new System.Drawing.Point(496, 27);
            this.lbNgayTao.Name = "lbNgayTao";
            this.lbNgayTao.Size = new System.Drawing.Size(68, 16);
            this.lbNgayTao.TabIndex = 2;
            this.lbNgayTao.Text = "Ngày Tạo";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(116, 18);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(100, 22);
            this.tbMaHD.TabIndex = 3;
            // 
            // dateTimePickerNgayTao
            // 
            this.dateTimePickerNgayTao.Location = new System.Drawing.Point(588, 24);
            this.dateTimePickerNgayTao.Name = "dateTimePickerNgayTao";
            this.dateTimePickerNgayTao.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNgayTao.TabIndex = 5;
            // 
            // dataGridViewHDB
            // 
            this.dataGridViewHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHDB.Location = new System.Drawing.Point(15, 52);
            this.dataGridViewHDB.Name = "dataGridViewHDB";
            this.dataGridViewHDB.RowHeadersWidth = 51;
            this.dataGridViewHDB.RowTemplate.Height = 24;
            this.dataGridViewHDB.Size = new System.Drawing.Size(1120, 384);
            this.dataGridViewHDB.TabIndex = 6;
            this.dataGridViewHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHDB_CellClick);
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(347, 21);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(121, 24);
            this.cbNV.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 455);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 39);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(189, 455);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 38);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(380, 455);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 38);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(575, 455);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(113, 38);
            this.btnTK.TabIndex = 11;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnXemCT
            // 
            this.btnXemCT.Location = new System.Drawing.Point(758, 455);
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(101, 38);
            this.btnXemCT.TabIndex = 12;
            this.btnXemCT.Text = "Xem chi tiết";
            this.btnXemCT.UseVisualStyleBackColor = true;
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click_1);
            // 
            // HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 521);
            this.Controls.Add(this.btnXemCT);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.dataGridViewHDB);
            this.Controls.Add(this.dateTimePickerNgayTao);
            this.Controls.Add(this.tbMaHD);
            this.Controls.Add(this.lbNgayTao);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.lbMaHD);
            this.Name = "HoaDonBan";
            this.Text = "HoaDonBan";
            this.Load += new System.EventHandler(this.HoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbNgayTao;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTao;
        private System.Windows.Forms.DataGridView dataGridViewHDB;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnXemCT;
    }
}