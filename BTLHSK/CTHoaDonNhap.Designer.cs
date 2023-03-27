namespace BTLHSK
{
    partial class CTHoaDonNhap
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
            this.components = new System.ComponentModel.Container();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbMaMH = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbDG = new System.Windows.Forms.Label();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.tbDG = new System.Windows.Forms.TextBox();
            this.dataGridViewCTHDN = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.errorProviderSL = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDG = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(24, 32);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(78, 16);
            this.lbMaHD.TabIndex = 0;
            this.lbMaHD.Text = "Mã hoá đơn";
            // 
            // lbMaMH
            // 
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Location = new System.Drawing.Point(25, 85);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(84, 16);
            this.lbMaMH.TabIndex = 1;
            this.lbMaMH.Text = "Mã mặt hàng";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(24, 151);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(60, 16);
            this.lbSL.TabIndex = 2;
            this.lbSL.Text = "Số lượng";
            // 
            // lbDG
            // 
            this.lbDG.AutoSize = true;
            this.lbDG.Location = new System.Drawing.Point(24, 205);
            this.lbDG.Name = "lbDG";
            this.lbDG.Size = new System.Drawing.Size(53, 16);
            this.lbDG.TabIndex = 3;
            this.lbDG.Text = "Đơn giá";
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(143, 24);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(121, 24);
            this.cbMaHD.TabIndex = 4;
            // 
            // cbMaMH
            // 
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(143, 82);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(121, 24);
            this.cbMaMH.TabIndex = 5;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(143, 145);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(100, 22);
            this.tbSL.TabIndex = 6;
            // 
            // tbDG
            // 
            this.tbDG.Location = new System.Drawing.Point(143, 199);
            this.tbDG.Name = "tbDG";
            this.tbDG.Size = new System.Drawing.Size(100, 22);
            this.tbDG.TabIndex = 7;
            // 
            // dataGridViewCTHDN
            // 
            this.dataGridViewCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHDN.Location = new System.Drawing.Point(356, 24);
            this.dataGridViewCTHDN.Name = "dataGridViewCTHDN";
            this.dataGridViewCTHDN.RowHeadersWidth = 51;
            this.dataGridViewCTHDN.RowTemplate.Height = 24;
            this.dataGridViewCTHDN.Size = new System.Drawing.Size(720, 432);
            this.dataGridViewCTHDN.TabIndex = 8;
            this.dataGridViewCTHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTHDN_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 284);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 61);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(130, 284);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 61);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(244, 284);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 61);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(28, 391);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(94, 65);
            this.btnTK.TabIndex = 13;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // errorProviderSL
            // 
            this.errorProviderSL.ContainerControl = this;
            // 
            // errorProviderDG
            // 
            this.errorProviderDG.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(12, 8);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CTHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewCTHDN);
            this.Controls.Add(this.tbDG);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.cbMaMH);
            this.Controls.Add(this.cbMaHD);
            this.Controls.Add(this.lbDG);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbMaMH);
            this.Controls.Add(this.lbMaHD);
            this.Name = "CTHoaDonNhap";
            this.Text = "CTHoaDonNhap";
            this.Load += new System.EventHandler(this.CTHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbMaMH;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbDG;
        private System.Windows.Forms.ComboBox cbMaHD;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.TextBox tbDG;
        private System.Windows.Forms.DataGridView dataGridViewCTHDN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.ErrorProvider errorProviderSL;
        private System.Windows.Forms.ErrorProvider errorProviderDG;
        private System.Windows.Forms.Button button2;
    }
}