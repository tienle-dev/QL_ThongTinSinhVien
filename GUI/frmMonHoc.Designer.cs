﻿namespace GUI
{
    partial class frmMonHoc
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
            this.comboBoxTinchi = new System.Windows.Forms.ComboBox();
            this.txtTenmon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTietthuchanh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTietlythuyet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMamon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewDanhsachmon = new System.Windows.Forms.DataGridView();
            this.mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietlythuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietthuchanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhsachmon)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTinchi
            // 
            this.comboBoxTinchi.FormattingEnabled = true;
            this.comboBoxTinchi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxTinchi.Location = new System.Drawing.Point(147, 102);
            this.comboBoxTinchi.Name = "comboBoxTinchi";
            this.comboBoxTinchi.Size = new System.Drawing.Size(74, 24);
            this.comboBoxTinchi.TabIndex = 13;
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(442, 52);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(371, 22);
            this.txtTenmon.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên môn:";
            // 
            // txtTietthuchanh
            // 
            this.txtTietthuchanh.Location = new System.Drawing.Point(723, 100);
            this.txtTietthuchanh.Name = "txtTietthuchanh";
            this.txtTietthuchanh.Size = new System.Drawing.Size(88, 22);
            this.txtTietthuchanh.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tiết thực hành: ";
            // 
            // txtTietlythuyet
            // 
            this.txtTietlythuyet.Location = new System.Drawing.Point(442, 102);
            this.txtTietlythuyet.Name = "txtTietlythuyet";
            this.txtTietlythuyet.Size = new System.Drawing.Size(89, 22);
            this.txtTietlythuyet.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tiết lý thuyết: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số tín chỉ:";
            // 
            // txtMamon
            // 
            this.txtMamon.Location = new System.Drawing.Point(147, 48);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Size = new System.Drawing.Size(164, 22);
            this.txtMamon.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã môn: ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(684, 160);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(115, 40);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(486, 160);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 40);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(351, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 40);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(216, 160);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 40);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(81, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 40);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDanhsachmon
            // 
            this.dataGridViewDanhsachmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhsachmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamon,
            this.tenmon,
            this.sotinchi,
            this.tietlythuyet,
            this.tietthuchanh});
            this.dataGridViewDanhsachmon.Location = new System.Drawing.Point(44, 223);
            this.dataGridViewDanhsachmon.Name = "dataGridViewDanhsachmon";
            this.dataGridViewDanhsachmon.RowHeadersWidth = 51;
            this.dataGridViewDanhsachmon.RowTemplate.Height = 24;
            this.dataGridViewDanhsachmon.Size = new System.Drawing.Size(803, 206);
            this.dataGridViewDanhsachmon.TabIndex = 19;
            // 
            // mamon
            // 
            this.mamon.HeaderText = "Mã môn";
            this.mamon.MinimumWidth = 6;
            this.mamon.Name = "mamon";
            this.mamon.Width = 125;
            // 
            // tenmon
            // 
            this.tenmon.HeaderText = "Tên môn";
            this.tenmon.MinimumWidth = 6;
            this.tenmon.Name = "tenmon";
            this.tenmon.Width = 250;
            // 
            // sotinchi
            // 
            this.sotinchi.HeaderText = "Số tín chỉ";
            this.sotinchi.MinimumWidth = 6;
            this.sotinchi.Name = "sotinchi";
            this.sotinchi.Width = 125;
            // 
            // tietlythuyet
            // 
            this.tietlythuyet.HeaderText = "Tiết lý thuyết";
            this.tietlythuyet.MinimumWidth = 6;
            this.tietlythuyet.Name = "tietlythuyet";
            this.tietlythuyet.Width = 125;
            // 
            // tietthuchanh
            // 
            this.tietthuchanh.HeaderText = "Tiết thực hành";
            this.tietthuchanh.MinimumWidth = 6;
            this.tietthuchanh.Name = "tietthuchanh";
            this.tietthuchanh.Width = 125;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.dataGridViewDanhsachmon);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.comboBoxTinchi);
            this.Controls.Add(this.txtTenmon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTietthuchanh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTietlythuyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMamon);
            this.Controls.Add(this.label1);
            this.Name = "frmMonHoc";
            this.Text = "Quản lý môn học";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhsachmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTinchi;
        private System.Windows.Forms.TextBox txtTenmon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTietthuchanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTietlythuyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMamon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewDanhsachmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietlythuyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietthuchanh;
    }
}