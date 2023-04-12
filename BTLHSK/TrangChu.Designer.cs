namespace BTLHSK
{
    partial class TrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnQL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQL,
            this.mnThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1395, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnQL
            // 
            this.mnQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNV,
            this.mnMH,
            this.mnHDN,
            this.mnHDB});
            this.mnQL.Name = "mnQL";
            this.mnQL.Size = new System.Drawing.Size(75, 24);
            this.mnQL.Text = "Quản Lý";
            // 
            // mnNV
            // 
            this.mnNV.Name = "mnNV";
            this.mnNV.Size = new System.Drawing.Size(224, 26);
            this.mnNV.Text = "Nhân Viên";
            this.mnNV.Click += new System.EventHandler(this.mnNV_Click);
            // 
            // mnMH
            // 
            this.mnMH.Name = "mnMH";
            this.mnMH.Size = new System.Drawing.Size(224, 26);
            this.mnMH.Text = "Mặt Hàng";
            this.mnMH.Click += new System.EventHandler(this.mnMH_Click);
            // 
            // mnHDN
            // 
            this.mnHDN.Name = "mnHDN";
            this.mnHDN.Size = new System.Drawing.Size(224, 26);
            this.mnHDN.Text = "Hoá Đơn Nhập";
            this.mnHDN.Click += new System.EventHandler(this.mnHDN_Click);
            // 
            // mnHDB
            // 
            this.mnHDB.Name = "mnHDB";
            this.mnHDB.Size = new System.Drawing.Size(224, 26);
            this.mnHDB.Text = "Hoá Đơn Bán";
            this.mnHDB.Click += new System.EventHandler(this.mnHDB_Click);
            // 
            // mnThoat
            // 
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(65, 24);
            this.mnThoat.Text = "Thoát ";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 669);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "TrangChu";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnQL;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnNV;
        private System.Windows.Forms.ToolStripMenuItem mnMH;
        private System.Windows.Forms.ToolStripMenuItem mnHDN;
        private System.Windows.Forms.ToolStripMenuItem mnHDB;
    }
}

