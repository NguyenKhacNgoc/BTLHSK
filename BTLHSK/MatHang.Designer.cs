namespace BTLHSK
{
    partial class MatHang
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
            this.lbMaMH = new System.Windows.Forms.Label();
            this.lbTMH = new System.Windows.Forms.Label();
            this.lbMS = new System.Windows.Forms.Label();
            this.tbMaMH = new System.Windows.Forms.TextBox();
            this.tbTenLH = new System.Windows.Forms.TextBox();
            this.tbMS = new System.Windows.Forms.TextBox();
            this.dataGridViewMH = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaMH
            // 
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Location = new System.Drawing.Point(12, 30);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(84, 16);
            this.lbMaMH.TabIndex = 0;
            this.lbMaMH.Text = "Mã mặt hàng";
            // 
            // lbTMH
            // 
            this.lbTMH.AutoSize = true;
            this.lbTMH.Location = new System.Drawing.Point(12, 87);
            this.lbTMH.Name = "lbTMH";
            this.lbTMH.Size = new System.Drawing.Size(89, 16);
            this.lbTMH.TabIndex = 2;
            this.lbTMH.Text = "Tên loại hàng";
            // 
            // lbMS
            // 
            this.lbMS.AutoSize = true;
            this.lbMS.Location = new System.Drawing.Point(14, 135);
            this.lbMS.Name = "lbMS";
            this.lbMS.Size = new System.Drawing.Size(58, 16);
            this.lbMS.TabIndex = 3;
            this.lbMS.Text = "Màu sắc";
            // 
            // tbMaMH
            // 
            this.tbMaMH.Location = new System.Drawing.Point(126, 30);
            this.tbMaMH.Name = "tbMaMH";
            this.tbMaMH.Size = new System.Drawing.Size(100, 22);
            this.tbMaMH.TabIndex = 6;
            // 
            // tbTenLH
            // 
            this.tbTenLH.Location = new System.Drawing.Point(126, 87);
            this.tbTenLH.Name = "tbTenLH";
            this.tbTenLH.Size = new System.Drawing.Size(100, 22);
            this.tbTenLH.TabIndex = 7;
            // 
            // tbMS
            // 
            this.tbMS.Location = new System.Drawing.Point(105, 135);
            this.tbMS.Name = "tbMS";
            this.tbMS.Size = new System.Drawing.Size(100, 22);
            this.tbMS.TabIndex = 8;
            // 
            // dataGridViewMH
            // 
            this.dataGridViewMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMH.Location = new System.Drawing.Point(320, 24);
            this.dataGridViewMH.Name = "dataGridViewMH";
            this.dataGridViewMH.RowHeadersWidth = 51;
            this.dataGridViewMH.RowTemplate.Height = 24;
            this.dataGridViewMH.Size = new System.Drawing.Size(750, 391);
            this.dataGridViewMH.TabIndex = 12;
            this.dataGridViewMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMH_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 286);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 49);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(151, 286);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 49);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(25, 363);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 54);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(151, 363);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(96, 52);
            this.btnTK.TabIndex = 16;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnCN
            // 
            this.btnCN.Location = new System.Drawing.Point(74, 434);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(121, 67);
            this.btnCN.TabIndex = 17;
            this.btnCN.Text = "Cập nhật";
            this.btnCN.UseVisualStyleBackColor = true;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 564);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewMH);
            this.Controls.Add(this.tbMS);
            this.Controls.Add(this.tbTenLH);
            this.Controls.Add(this.tbMaMH);
            this.Controls.Add(this.lbMS);
            this.Controls.Add(this.lbTMH);
            this.Controls.Add(this.lbMaMH);
            this.Name = "MatHang";
            this.Text = "MatHang";
            this.Load += new System.EventHandler(this.MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaMH;
        private System.Windows.Forms.Label lbTMH;
        private System.Windows.Forms.Label lbMS;
        private System.Windows.Forms.TextBox tbMaMH;
        private System.Windows.Forms.TextBox tbTenLH;
        private System.Windows.Forms.TextBox tbMS;
        private System.Windows.Forms.DataGridView dataGridViewMH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnCN;
    }
}