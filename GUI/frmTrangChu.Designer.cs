namespace GUI
{
    partial class frmTrangChu
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
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NganhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SinhVienToolStripMenuItem,
            this.MonHocToolStripMenuItem,
            this.DiemToolStripMenuItem,
            this.KhoaToolStripMenuItem,
            this.NganhToolStripMenuItem,
            this.LopToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // SinhVienToolStripMenuItem
            // 
            this.SinhVienToolStripMenuItem.Name = "SinhVienToolStripMenuItem";
            this.SinhVienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SinhVienToolStripMenuItem.Text = "Quản lý sinh viên";
            this.SinhVienToolStripMenuItem.Click += new System.EventHandler(this.SinhVienToolStripMenuItem_Click);
            // 
            // MonHocToolStripMenuItem
            // 
            this.MonHocToolStripMenuItem.Name = "MonHocToolStripMenuItem";
            this.MonHocToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.MonHocToolStripMenuItem.Text = "Quản lý môn học";
            this.MonHocToolStripMenuItem.Click += new System.EventHandler(this.MonHocToolStripMenuItem_Click);
            // 
            // DiemToolStripMenuItem
            // 
            this.DiemToolStripMenuItem.Name = "DiemToolStripMenuItem";
            this.DiemToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DiemToolStripMenuItem.Text = "Quản lý điểm";
            this.DiemToolStripMenuItem.Click += new System.EventHandler(this.DiemToolStripMenuItem_Click);
            // 
            // KhoaToolStripMenuItem
            // 
            this.KhoaToolStripMenuItem.Name = "KhoaToolStripMenuItem";
            this.KhoaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.KhoaToolStripMenuItem.Text = "Quản lý khoa";
            this.KhoaToolStripMenuItem.Click += new System.EventHandler(this.KhoaToolStripMenuItem_Click);
            // 
            // NganhToolStripMenuItem
            // 
            this.NganhToolStripMenuItem.Name = "NganhToolStripMenuItem";
            this.NganhToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.NganhToolStripMenuItem.Text = "Quản lý ngành";
            this.NganhToolStripMenuItem.Click += new System.EventHandler(this.NganhToolStripMenuItem_Click);
            // 
            // LopToolStripMenuItem
            // 
            this.LopToolStripMenuItem.Name = "LopToolStripMenuItem";
            this.LopToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.LopToolStripMenuItem.Text = "Quản lý lớp";
            this.LopToolStripMenuItem.Click += new System.EventHandler(this.LopToolStripMenuItem_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChu";
            this.Text = "Phần mềm quản lý thông tin sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTrangChu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MonHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NganhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LopToolStripMenuItem;
    }
}