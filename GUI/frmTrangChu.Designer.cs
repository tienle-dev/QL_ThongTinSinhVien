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
            this.lblUserValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1096, 33);
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
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // SinhVienToolStripMenuItem
            // 
            this.SinhVienToolStripMenuItem.Name = "SinhVienToolStripMenuItem";
            this.SinhVienToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.SinhVienToolStripMenuItem.Text = "Quản lý sinh viên";
            this.SinhVienToolStripMenuItem.Click += new System.EventHandler(this.SinhVienToolStripMenuItem_Click);
            // 
            // MonHocToolStripMenuItem
            // 
            this.MonHocToolStripMenuItem.Name = "MonHocToolStripMenuItem";
            this.MonHocToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.MonHocToolStripMenuItem.Text = "Quản lý môn học";
            this.MonHocToolStripMenuItem.Click += new System.EventHandler(this.MonHocToolStripMenuItem_Click);
            // 
            // DiemToolStripMenuItem
            // 
            this.DiemToolStripMenuItem.Name = "DiemToolStripMenuItem";
            this.DiemToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.DiemToolStripMenuItem.Text = "Quản lý điểm";
            this.DiemToolStripMenuItem.Click += new System.EventHandler(this.DiemToolStripMenuItem_Click);
            // 
            // KhoaToolStripMenuItem
            // 
            this.KhoaToolStripMenuItem.Name = "KhoaToolStripMenuItem";
            this.KhoaToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.KhoaToolStripMenuItem.Text = "Quản lý khoa";
            this.KhoaToolStripMenuItem.Click += new System.EventHandler(this.KhoaToolStripMenuItem_Click);
            // 
            // NganhToolStripMenuItem
            // 
            this.NganhToolStripMenuItem.Name = "NganhToolStripMenuItem";
            this.NganhToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.NganhToolStripMenuItem.Text = "Quản lý ngành";
            this.NganhToolStripMenuItem.Click += new System.EventHandler(this.NganhToolStripMenuItem_Click);
            // 
            // LopToolStripMenuItem
            // 
            this.LopToolStripMenuItem.Name = "LopToolStripMenuItem";
            this.LopToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.LopToolStripMenuItem.Text = "Quản lý lớp";
            this.LopToolStripMenuItem.Click += new System.EventHandler(this.LopToolStripMenuItem_Click);
            // 
            // lblUserValue
            // 
            this.lblUserValue.AutoSize = true;
            this.lblUserValue.Location = new System.Drawing.Point(552, 400);
            this.lblUserValue.Name = "lblUserValue";
            this.lblUserValue.Size = new System.Drawing.Size(21, 20);
            this.lblUserValue.TabIndex = 28;
            this.lblUserValue.Text = "...";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Location = new System.Drawing.Point(552, 445);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(21, 20);
            this.lblNameValue.TabIndex = 27;
            this.lblNameValue.Text = "...";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(552, 400);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 20);
            this.lblUserId.TabIndex = 26;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(463, 495);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(171, 53);
            this.btnSignOut.TabIndex = 25;
            this.btnSignOut.Text = "Đăng xuất";
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(429, 445);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 20);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Họ và tên:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(395, 400);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(115, 20);
            this.lblUser.TabIndex = 23;
            this.lblUser.Text = "Mã đăng nhập:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(459, 351);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(155, 20);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "Thông tin đăng nhập";
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Location = new System.Drawing.Point(344, 50);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(436, 115);
            this.lblHome.TabIndex = 21;
            this.lblHome.Text = "TRANG CHỦ";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFaculty
            // 
            this.btnFaculty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaculty.Location = new System.Drawing.Point(373, 195);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(175, 104);
            this.btnFaculty.TabIndex = 20;
            this.btnFaculty.Text = "Khoa-Nghành";
            this.btnFaculty.UseVisualStyleBackColor = true;
            // 
            // btnScore
            // 
            this.btnScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.Location = new System.Drawing.Point(916, 195);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(175, 104);
            this.btnScore.TabIndex = 19;
            this.btnScore.Text = "Điểm";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // btnSubject
            // 
            this.btnSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubject.Location = new System.Drawing.Point(735, 195);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(175, 104);
            this.btnSubject.TabIndex = 18;
            this.btnSubject.Text = "Môn Học";
            this.btnSubject.UseVisualStyleBackColor = true;
            // 
            // btnClass
            // 
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(554, 195);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(175, 104);
            this.btnClass.TabIndex = 17;
            this.btnClass.Text = "Lớp Học";
            this.btnClass.UseVisualStyleBackColor = true;
            // 
            // btnTeacher
            // 
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.Location = new System.Drawing.Point(192, 195);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(175, 104);
            this.btnTeacher.TabIndex = 16;
            this.btnTeacher.Text = "Giảng Viên";
            this.btnTeacher.UseVisualStyleBackColor = true;
            // 
            // btnStudent
            // 
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(11, 195);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(175, 104);
            this.btnStudent.TabIndex = 15;
            this.btnStudent.Text = "Sinh Viên";
            this.btnStudent.UseVisualStyleBackColor = true;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 636);
            this.Controls.Add(this.lblUserValue);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnFaculty);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTrangChu";
            this.Text = "Phần mềm quản lý thông tin sinh viên";
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
        private System.Windows.Forms.Label lblUserValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnFaculty;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnStudent;
    }
}