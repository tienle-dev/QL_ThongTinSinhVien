namespace GUI
{
    partial class frmDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDanhsachmonhoc = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dataGridViewNhapdiem = new System.Windows.Forms.DataGridView();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemgk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTinhDiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhapdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn môn học:";
            // 
            // comboBoxDanhsachmonhoc
            // 
            this.comboBoxDanhsachmonhoc.FormattingEnabled = true;
            this.comboBoxDanhsachmonhoc.Location = new System.Drawing.Point(158, 42);
            this.comboBoxDanhsachmonhoc.Name = "comboBoxDanhsachmonhoc";
            this.comboBoxDanhsachmonhoc.Size = new System.Drawing.Size(495, 24);
            this.comboBoxDanhsachmonhoc.TabIndex = 1;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(682, 32);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(132, 40);
            this.btnLoc.TabIndex = 19;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNhapdiem
            // 
            this.dataGridViewNhapdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhapdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.hoten,
            this.lop,
            this.ngaysinh,
            this.diemgk,
            this.diemck,
            this.diemtb,
            this.trangthai});
            this.dataGridViewNhapdiem.Location = new System.Drawing.Point(32, 104);
            this.dataGridViewNhapdiem.Name = "dataGridViewNhapdiem";
            this.dataGridViewNhapdiem.RowHeadersWidth = 51;
            this.dataGridViewNhapdiem.RowTemplate.Height = 24;
            this.dataGridViewNhapdiem.Size = new System.Drawing.Size(1128, 344);
            this.dataGridViewNhapdiem.TabIndex = 20;
            // 
            // mssv
            // 
            this.mssv.HeaderText = "MSSV";
            this.mssv.MinimumWidth = 6;
            this.mssv.Name = "mssv";
            this.mssv.Width = 125;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 200;
            // 
            // lop
            // 
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // diemgk
            // 
            this.diemgk.HeaderText = "Điểm giữa kỳ";
            this.diemgk.MinimumWidth = 6;
            this.diemgk.Name = "diemgk";
            this.diemgk.Width = 125;
            // 
            // diemck
            // 
            this.diemck.HeaderText = "Điểm cuối kỳ";
            this.diemck.MinimumWidth = 6;
            this.diemck.Name = "diemck";
            this.diemck.Width = 125;
            // 
            // diemtb
            // 
            this.diemtb.HeaderText = "Điểm trung bình";
            this.diemtb.MinimumWidth = 6;
            this.diemtb.Name = "diemtb";
            this.diemtb.Width = 125;
            // 
            // trangthai
            // 
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 125;
            // 
            // btnTinhDiem
            // 
            this.btnTinhDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhDiem.Location = new System.Drawing.Point(34, 454);
            this.btnTinhDiem.Name = "btnTinhDiem";
            this.btnTinhDiem.Size = new System.Drawing.Size(132, 40);
            this.btnTinhDiem.TabIndex = 19;
            this.btnTinhDiem.Text = "Tính điểm";
            this.btnTinhDiem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(949, 454);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(211, 40);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu và hoàn tất";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 543);
            this.Controls.Add(this.dataGridViewNhapdiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTinhDiem);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.comboBoxDanhsachmonhoc);
            this.Controls.Add(this.label1);
            this.Name = "frmDiem";
            this.Text = "Quản lý điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhapdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDanhsachmonhoc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridView dataGridViewNhapdiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemgk;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemck;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Button btnTinhDiem;
        private System.Windows.Forms.Button btnLuu;
    }
}