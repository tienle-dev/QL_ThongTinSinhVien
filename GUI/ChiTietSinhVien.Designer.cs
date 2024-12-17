namespace GUI {
    partial class ChiTietSinhVien {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbBirthYear = new System.Windows.Forms.ComboBox();
            this.cbSession = new System.Windows.Forms.ComboBox();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtAdvisor = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblAdvisor = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(673, 708);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 53);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(503, 708);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 53);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // cbBirthYear
            // 
            this.cbBirthYear.FormattingEnabled = true;
            this.cbBirthYear.Items.AddRange(new object[] {
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009"});
            this.cbBirthYear.Location = new System.Drawing.Point(456, 227);
            this.cbBirthYear.Name = "cbBirthYear";
            this.cbBirthYear.Size = new System.Drawing.Size(121, 28);
            this.cbBirthYear.TabIndex = 57;
            // 
            // cbSession
            // 
            this.cbSession.FormattingEnabled = true;
            this.cbSession.Items.AddRange(new object[] {
            "2000-2004",
            "2004-2008",
            "2008-2012",
            "2012-2016",
            "2016-2020",
            "2020-2024",
            "2024-2028"});
            this.cbSession.Location = new System.Drawing.Point(456, 574);
            this.cbSession.Name = "cbSession";
            this.cbSession.Size = new System.Drawing.Size(121, 28);
            this.cbSession.TabIndex = 56;
            // 
            // cbFaculty
            // 
            this.cbFaculty.FormattingEnabled = true;
            this.cbFaculty.Location = new System.Drawing.Point(456, 526);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(121, 28);
            this.cbFaculty.TabIndex = 55;
            // 
            // cbMajor
            // 
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(456, 485);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(121, 28);
            this.cbMajor.TabIndex = 54;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(456, 443);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 28);
            this.cbClass.TabIndex = 53;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(585, 286);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(54, 24);
            this.rdbFemale.TabIndex = 52;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Nữ";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(468, 286);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(67, 24);
            this.rdbMale.TabIndex = 51;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtAdvisor
            // 
            this.txtAdvisor.Location = new System.Drawing.Point(456, 629);
            this.txtAdvisor.Name = "txtAdvisor";
            this.txtAdvisor.Size = new System.Drawing.Size(251, 26);
            this.txtAdvisor.TabIndex = 50;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(456, 388);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(251, 26);
            this.txtPhoneNum.TabIndex = 49;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(456, 339);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 26);
            this.txtEmail.TabIndex = 48;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(456, 184);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(251, 26);
            this.txtFullName.TabIndex = 47;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(456, 135);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(251, 26);
            this.txtMSSV.TabIndex = 46;
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.AutoSize = true;
            this.lblAdvisor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisor.Location = new System.Drawing.Point(307, 629);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(122, 24);
            this.lblAdvisor.TabIndex = 45;
            this.lblAdvisor.Text = "Tên cố vấn:";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(323, 577);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(111, 24);
            this.lblSession.TabIndex = 44;
            this.lblSession.Text = "Niên khóa:";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(361, 531);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(66, 24);
            this.lblFaculty.TabIndex = 43;
            this.lblFaculty.Text = "Khoa:";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajor.Location = new System.Drawing.Point(339, 485);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(90, 24);
            this.lblMajor.TabIndex = 42;
            this.lblMajor.Text = "Nghành:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(337, 443);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(90, 24);
            this.lblClass.TabIndex = 41;
            this.lblClass.Text = "Tên lớp:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(288, 390);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(141, 24);
            this.lblPhoneNum.TabIndex = 40;
            this.lblPhoneNum.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(361, 339);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 24);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(334, 285);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(100, 24);
            this.lblSex.TabIndex = 38;
            this.lblSex.Text = "Giới tính:";
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthYear.Location = new System.Drawing.Point(331, 232);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(105, 24);
            this.lblBirthYear.TabIndex = 37;
            this.lblBirthYear.Text = "Năm sinh:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(329, 186);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(107, 24);
            this.lblFullName.TabIndex = 36;
            this.lblFullName.Text = "Họ và tên:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(364, 137);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(72, 24);
            this.lblId.TabIndex = 35;
            this.lblId.Text = "MSSV:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(418, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(521, 46);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Thông tin chi tiết Sinh Viên";
            // 
            // ChiTietSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 785);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbBirthYear);
            this.Controls.Add(this.cbSession);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.cbMajor);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.txtAdvisor);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lblAdvisor);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitle);
            this.Name = "ChiTietSinhVien";
            this.Text = "ChiTietSinhVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbBirthYear;
        private System.Windows.Forms.ComboBox cbSession;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.TextBox txtAdvisor;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblAdvisor;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitle;
    }
}