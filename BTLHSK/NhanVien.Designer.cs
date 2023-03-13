namespace BTLHSK
{
    partial class NhanVien
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
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(21, 31);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(91, 16);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(289, 31);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(31, 16);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(531, 34);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(92, 16);
            this.lbSDT.TabIndex = 2;
            this.lbSDT.Text = "Số Điện Thoại";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(140, 28);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(100, 22);
            this.tbMaNV.TabIndex = 3;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(367, 25);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(100, 22);
            this.tbTen.TabIndex = 4;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(670, 31);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(100, 22);
            this.tbSDT.TabIndex = 5;
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Location = new System.Drawing.Point(24, 72);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.RowHeadersWidth = 51;
            this.dataGridViewNV.RowTemplate.Height = 24;
            this.dataGridViewNV.Size = new System.Drawing.Size(746, 211);
            this.dataGridViewNV.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(39, 352);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 39);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(227, 352);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 38);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(431, 353);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 38);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(638, 352);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(113, 38);
            this.btnTK.TabIndex = 10;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewNV);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMaNV);
            this.Name = "NhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTK;
    }
}