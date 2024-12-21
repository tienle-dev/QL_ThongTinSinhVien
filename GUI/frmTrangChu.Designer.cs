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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnFaculty1 = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnFaculty2 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(1159, 28);
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
            this.SinhVienToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.SinhVienToolStripMenuItem.Text = "Quản lý sinh viên";
            this.SinhVienToolStripMenuItem.Click += new System.EventHandler(this.SinhVienToolStripMenuItem_Click);
            // 
            // MonHocToolStripMenuItem
            // 
            this.MonHocToolStripMenuItem.Name = "MonHocToolStripMenuItem";
            this.MonHocToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.MonHocToolStripMenuItem.Text = "Quản lý môn học";
            this.MonHocToolStripMenuItem.Click += new System.EventHandler(this.MonHocToolStripMenuItem_Click);
            // 
            // DiemToolStripMenuItem
            // 
            this.DiemToolStripMenuItem.Name = "DiemToolStripMenuItem";
            this.DiemToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.DiemToolStripMenuItem.Text = "Quản lý điểm";
            this.DiemToolStripMenuItem.Click += new System.EventHandler(this.DiemToolStripMenuItem_Click);
            // 
            // KhoaToolStripMenuItem
            // 
            this.KhoaToolStripMenuItem.Name = "KhoaToolStripMenuItem";
            this.KhoaToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.KhoaToolStripMenuItem.Text = "Quản lý khoa";
            this.KhoaToolStripMenuItem.Click += new System.EventHandler(this.KhoaToolStripMenuItem_Click);
            // 
            // NganhToolStripMenuItem
            // 
            this.NganhToolStripMenuItem.Name = "NganhToolStripMenuItem";
            this.NganhToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.NganhToolStripMenuItem.Text = "Quản lý ngành";
            this.NganhToolStripMenuItem.Click += new System.EventHandler(this.NganhToolStripMenuItem_Click);
            // 
            // LopToolStripMenuItem
            // 
            this.LopToolStripMenuItem.Name = "LopToolStripMenuItem";
            this.LopToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.LopToolStripMenuItem.Text = "Quản lý lớp";
            this.LopToolStripMenuItem.Click += new System.EventHandler(this.LopToolStripMenuItem_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(1048, 40);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(88, 28);
            this.btnSignOut.TabIndex = 25;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Location = new System.Drawing.Point(367, 40);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(388, 92);
            this.lblHome.TabIndex = 21;
            this.lblHome.Text = "TRANG CHỦ";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFaculty1
            // 
            this.btnFaculty1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaculty1.Location = new System.Drawing.Point(332, 156);
            this.btnFaculty1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFaculty1.Name = "btnFaculty1";
            this.btnFaculty1.Size = new System.Drawing.Size(156, 83);
            this.btnFaculty1.TabIndex = 20;
            this.btnFaculty1.Text = "Khoa";
            this.btnFaculty1.UseVisualStyleBackColor = true;
            this.btnFaculty1.Click += new System.EventHandler(this.btnFaculty1_Click);
            // 
            // btnScore
            // 
            this.btnScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.Location = new System.Drawing.Point(980, 156);
            this.btnScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(156, 83);
            this.btnScore.TabIndex = 19;
            this.btnScore.Text = "Điểm";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // btnSubject
            // 
            this.btnSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubject.Location = new System.Drawing.Point(818, 156);
            this.btnSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(156, 83);
            this.btnSubject.TabIndex = 18;
            this.btnSubject.Text = "Môn Học";
            this.btnSubject.UseVisualStyleBackColor = true;
            // 
            // btnClass
            // 
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(656, 156);
            this.btnClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(156, 83);
            this.btnClass.TabIndex = 17;
            this.btnClass.Text = "Lớp Học";
            this.btnClass.UseVisualStyleBackColor = true;
            // 
            // btnTeacher
            // 
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.Location = new System.Drawing.Point(171, 156);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(156, 83);
            this.btnTeacher.TabIndex = 16;
            this.btnTeacher.Text = "Giảng Viên";
            this.btnTeacher.UseVisualStyleBackColor = true;
            // 
            // btnStudent
            // 
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(10, 156);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(156, 83);
            this.btnStudent.TabIndex = 15;
            this.btnStudent.Text = "Sinh Viên";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnFaculty2
            // 
            this.btnFaculty2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaculty2.Location = new System.Drawing.Point(494, 156);
            this.btnFaculty2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFaculty2.Name = "btnFaculty2";
            this.btnFaculty2.Size = new System.Drawing.Size(156, 83);
            this.btnFaculty2.TabIndex = 20;
            this.btnFaculty2.Text = "Ngành";
            this.btnFaculty2.UseVisualStyleBackColor = true;
            this.btnFaculty2.Click += new System.EventHandler(this.btnFaculty1_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 509);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnFaculty2);
            this.Controls.Add(this.btnFaculty1);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.btnStudent);
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
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnFaculty1;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnFaculty2;
    }
}