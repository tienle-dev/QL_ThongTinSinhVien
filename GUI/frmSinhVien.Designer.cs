namespace GUI
{
    partial class frmSinhVien
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdvancedSearch = new System.Windows.Forms.Button();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Advisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbBirthYear = new System.Windows.Forms.ComboBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbCLass = new System.Windows.Forms.ComboBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.cbSession = new System.Windows.Forms.ComboBox();
            this.txtAdvisor = new System.Windows.Forms.TextBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblAdvisor = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.tlpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 46);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Quản lý sinh viên";
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdvancedSearch.Location = new System.Drawing.Point(766, 335);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(213, 43);
            this.btnAdvancedSearch.TabIndex = 11;
            this.btnAdvancedSearch.Text = "Tìm kiếm nâng cao";
            this.btnAdvancedSearch.UseVisualStyleBackColor = true;
            this.btnAdvancedSearch.Click += new System.EventHandler(this.btnAdvancedSearch_Click);
            // 
            // btnAdjust
            // 
            this.btnAdjust.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdjust.Location = new System.Drawing.Point(1557, 334);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(147, 44);
            this.btnAdjust.TabIndex = 10;
            this.btnAdjust.Text = "Chỉnh sủa ";
            this.btnAdjust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdjust.UseVisualStyleBackColor = true;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1710, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 44);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(80, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 43);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.BirthYear,
            this.Sex,
            this.Email,
            this.PhoneNum,
            this.Class,
            this.Major,
            this.Faculty,
            this.Session,
            this.Advisor});
            this.dgvSinhVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvSinhVien.Location = new System.Drawing.Point(80, 387);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.RowTemplate.Height = 28;
            this.dgvSinhVien.Size = new System.Drawing.Size(1718, 441);
            this.dgvSinhVien.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.HeaderText = "MSSV";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.Width = 150;
            // 
            // BirthYear
            // 
            this.BirthYear.HeaderText = "Năm sinh";
            this.BirthYear.MinimumWidth = 8;
            this.BirthYear.Name = "BirthYear";
            this.BirthYear.Width = 150;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Giới tính";
            this.Sex.MinimumWidth = 8;
            this.Sex.Name = "Sex";
            this.Sex.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "Số điện thoại";
            this.PhoneNum.MinimumWidth = 8;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Width = 150;
            // 
            // Class
            // 
            this.Class.HeaderText = "Tên lớp";
            this.Class.MinimumWidth = 8;
            this.Class.Name = "Class";
            this.Class.Width = 150;
            // 
            // Major
            // 
            this.Major.HeaderText = "Nghành";
            this.Major.MinimumWidth = 8;
            this.Major.Name = "Major";
            this.Major.Width = 150;
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Khoa";
            this.Faculty.MinimumWidth = 8;
            this.Faculty.Name = "Faculty";
            this.Faculty.Width = 150;
            // 
            // Session
            // 
            this.Session.HeaderText = "Niên khóa";
            this.Session.MinimumWidth = 8;
            this.Session.Name = "Session";
            this.Session.Width = 150;
            // 
            // Advisor
            // 
            this.Advisor.HeaderText = "Tên cố vấn";
            this.Advisor.MinimumWidth = 8;
            this.Advisor.Name = "Advisor";
            this.Advisor.Width = 150;
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 2;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearch.Controls.Add(this.lblAdvisor, 0, 10);
            this.tlpSearch.Controls.Add(this.lblSession, 0, 9);
            this.tlpSearch.Controls.Add(this.lblFaculty, 0, 8);
            this.tlpSearch.Controls.Add(this.lblMajor, 0, 7);
            this.tlpSearch.Controls.Add(this.lblClass, 0, 6);
            this.tlpSearch.Controls.Add(this.lblPhoneNum, 0, 5);
            this.tlpSearch.Controls.Add(this.lblEmail, 0, 4);
            this.tlpSearch.Controls.Add(this.lblSex, 0, 3);
            this.tlpSearch.Controls.Add(this.lblBirthYear, 0, 2);
            this.tlpSearch.Controls.Add(this.lblFullName, 0, 1);
            this.tlpSearch.Controls.Add(this.lblMSSV, 0, 0);
            this.tlpSearch.Controls.Add(this.txtMSSV, 1, 0);
            this.tlpSearch.Controls.Add(this.txtFullName, 1, 1);
            this.tlpSearch.Controls.Add(this.txtEmail, 1, 4);
            this.tlpSearch.Controls.Add(this.cbBirthYear, 1, 2);
            this.tlpSearch.Controls.Add(this.cbSex, 1, 3);
            this.tlpSearch.Controls.Add(this.cbCLass, 1, 6);
            this.tlpSearch.Controls.Add(this.txtPhoneNum, 1, 5);
            this.tlpSearch.Controls.Add(this.cbMajor, 1, 7);
            this.tlpSearch.Controls.Add(this.cbFaculty, 1, 8);
            this.tlpSearch.Controls.Add(this.cbSession, 1, 9);
            this.tlpSearch.Controls.Add(this.txtAdvisor, 1, 10);
            this.tlpSearch.Location = new System.Drawing.Point(1035, 8);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 11;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearch.Size = new System.Drawing.Size(334, 373);
            this.tlpSearch.TabIndex = 18;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(170, 3);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(161, 26);
            this.txtMSSV.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(170, 35);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(161, 26);
            this.txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(170, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // cbBirthYear
            // 
            this.cbBirthYear.FormattingEnabled = true;
            this.cbBirthYear.Location = new System.Drawing.Point(170, 67);
            this.cbBirthYear.Name = "cbBirthYear";
            this.cbBirthYear.Size = new System.Drawing.Size(121, 28);
            this.cbBirthYear.TabIndex = 3;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(170, 101);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 28);
            this.cbSex.TabIndex = 4;
            // 
            // cbCLass
            // 
            this.cbCLass.FormattingEnabled = true;
            this.cbCLass.Location = new System.Drawing.Point(170, 199);
            this.cbCLass.Name = "cbCLass";
            this.cbCLass.Size = new System.Drawing.Size(121, 28);
            this.cbCLass.TabIndex = 5;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(170, 167);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(161, 26);
            this.txtPhoneNum.TabIndex = 6;
            // 
            // cbMajor
            // 
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(170, 233);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(121, 28);
            this.cbMajor.TabIndex = 7;
            // 
            // cbFaculty
            // 
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Location = new System.Drawing.Point(170, 267);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(121, 28);
            this.cbFaculty.TabIndex = 8;
            // 
            // cbSession
            // 
            this.cbSession.FormattingEnabled = true;
            this.cbSession.Location = new System.Drawing.Point(170, 301);
            this.cbSession.Name = "cbSession";
            this.cbSession.Size = new System.Drawing.Size(121, 28);
            this.cbSession.TabIndex = 9;
            // 
            // txtAdvisor
            // 
            this.txtAdvisor.Location = new System.Drawing.Point(170, 335);
            this.txtAdvisor.Name = "txtAdvisor";
            this.txtAdvisor.Size = new System.Drawing.Size(161, 26);
            this.txtAdvisor.TabIndex = 10;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(3, 0);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(72, 24);
            this.lblMSSV.TabIndex = 36;
            this.lblMSSV.Text = "MSSV:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(3, 32);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(107, 24);
            this.lblFullName.TabIndex = 37;
            this.lblFullName.Text = "Họ và tên:";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthYear.Location = new System.Drawing.Point(3, 64);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(105, 24);
            this.lblBirthYear.TabIndex = 38;
            this.lblBirthYear.Text = "Năm sinh:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(3, 98);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(100, 24);
            this.lblSex.TabIndex = 39;
            this.lblSex.Text = "Giới tính:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 24);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(3, 164);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(141, 24);
            this.lblPhoneNum.TabIndex = 41;
            this.lblPhoneNum.Text = "Số điện thoại:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(3, 196);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(90, 24);
            this.lblClass.TabIndex = 42;
            this.lblClass.Text = "Tên lớp:";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajor.Location = new System.Drawing.Point(3, 230);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(90, 24);
            this.lblMajor.TabIndex = 43;
            this.lblMajor.Text = "Nghành:";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(3, 264);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(66, 24);
            this.lblFaculty.TabIndex = 44;
            this.lblFaculty.Text = "Khoa:";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(3, 298);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(111, 24);
            this.lblSession.TabIndex = 45;
            this.lblSession.Text = "Niên khóa:";
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.AutoSize = true;
            this.lblAdvisor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisor.Location = new System.Drawing.Point(3, 332);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(122, 24);
            this.lblAdvisor.TabIndex = 46;
            this.lblAdvisor.Text = "Tên cố vấn:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1413, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 49);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1853, 829);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tlpSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdvancedSearch);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSinhVien);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSinhVien";
            this.Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdvancedSearch;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn Advisor;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbBirthYear;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbCLass;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.ComboBox cbSession;
        private System.Windows.Forms.TextBox txtAdvisor;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblAdvisor;
        private System.Windows.Forms.Button btnSearch;
    }
}