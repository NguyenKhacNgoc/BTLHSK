namespace BTLHSK
{
    partial class HoaDonNhap
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
            this.lbNCC = new System.Windows.Forms.Label();
            this.lbNT = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.tbNCC = new System.Windows.Forms.TextBox();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNT = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewHDN = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnXemCT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(30, 28);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(78, 16);
            this.lbMaHD.TabIndex = 0;
            this.lbMaHD.Text = "Mã hoá đơn";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(30, 84);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(86, 16);
            this.lbTenNV.TabIndex = 1;
            this.lbTenNV.Text = "Mã nhân viên";
            // 
            // lbNCC
            // 
            this.lbNCC.AutoSize = true;
            this.lbNCC.Location = new System.Drawing.Point(26, 139);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(90, 16);
            this.lbNCC.TabIndex = 2;
            this.lbNCC.Text = "Nhà cung cấp";
            // 
            // lbNT
            // 
            this.lbNT.AutoSize = true;
            this.lbNT.Location = new System.Drawing.Point(30, 205);
            this.lbNT.Name = "lbNT";
            this.lbNT.Size = new System.Drawing.Size(62, 16);
            this.lbNT.TabIndex = 3;
            this.lbNT.Text = "Ngày tạo";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(150, 21);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(100, 22);
            this.tbMaHD.TabIndex = 4;
            // 
            // tbNCC
            // 
            this.tbNCC.Location = new System.Drawing.Point(150, 133);
            this.tbNCC.Name = "tbNCC";
            this.tbNCC.Size = new System.Drawing.Size(100, 22);
            this.tbNCC.TabIndex = 5;
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(150, 75);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(121, 24);
            this.cbNV.TabIndex = 6;
            // 
            // dateTimePickerNT
            // 
            this.dateTimePickerNT.Location = new System.Drawing.Point(150, 205);
            this.dateTimePickerNT.Name = "dateTimePickerNT";
            this.dateTimePickerNT.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNT.TabIndex = 7;
            // 
            // dataGridViewHDN
            // 
            this.dataGridViewHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHDN.Location = new System.Drawing.Point(420, 28);
            this.dataGridViewHDN.Name = "dataGridViewHDN";
            this.dataGridViewHDN.RowHeadersWidth = 51;
            this.dataGridViewHDN.RowTemplate.Height = 24;
            this.dataGridViewHDN.Size = new System.Drawing.Size(631, 433);
            this.dataGridViewHDN.TabIndex = 8;
            this.dataGridViewHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHDN_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 287);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 61);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(169, 287);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 61);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(284, 287);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 61);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(44, 376);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(94, 65);
            this.btnTK.TabIndex = 12;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnXemCT
            // 
            this.btnXemCT.Location = new System.Drawing.Point(201, 378);
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(107, 63);
            this.btnXemCT.TabIndex = 13;
            this.btnXemCT.Text = "Xem chi tiết";
            this.btnXemCT.UseVisualStyleBackColor = true;
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click_1);
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 575);
            this.Controls.Add(this.btnXemCT);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewHDN);
            this.Controls.Add(this.dateTimePickerNT);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.tbNCC);
            this.Controls.Add(this.tbMaHD);
            this.Controls.Add(this.lbNT);
            this.Controls.Add(this.lbNCC);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.lbMaHD);
            this.Name = "HoaDonNhap";
            this.Text = "HoaDonNhap";
            this.Load += new System.EventHandler(this.HoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbNCC;
        private System.Windows.Forms.Label lbNT;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.TextBox tbNCC;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerNT;
        private System.Windows.Forms.DataGridView dataGridViewHDN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnXemCT;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.ComboBox cbNV;
    }
}