namespace BTLHSK
{
    partial class RP_CTHDB
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
            this.crp_CTHDB = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp_CTHDB
            // 
            this.crp_CTHDB.ActiveViewIndex = -1;
            this.crp_CTHDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_CTHDB.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_CTHDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_CTHDB.Location = new System.Drawing.Point(0, 0);
            this.crp_CTHDB.Name = "crp_CTHDB";
            this.crp_CTHDB.Size = new System.Drawing.Size(800, 450);
            this.crp_CTHDB.TabIndex = 0;
            // 
            // RP_CTHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crp_CTHDB);
            this.Name = "RP_CTHDB";
            this.Text = "RP_CTHDB";
            this.Load += new System.EventHandler(this.RP_CTHDB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_CTHDB;
    }
}