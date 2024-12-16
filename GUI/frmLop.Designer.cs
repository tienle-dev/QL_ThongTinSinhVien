namespace GUI
{
    partial class frmLop
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
            this.comboBoxDanhsachnganh = new System.Windows.Forms.ComboBox();
            this.dataGridViewDanhsachlop = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhsachlop)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDanhsachnganh
            // 
            this.comboBoxDanhsachnganh.FormattingEnabled = true;
            this.comboBoxDanhsachnganh.Location = new System.Drawing.Point(156, 107);
            this.comboBoxDanhsachnganh.Name = "comboBoxDanhsachnganh";
            this.comboBoxDanhsachnganh.Size = new System.Drawing.Size(291, 24);
            this.comboBoxDanhsachnganh.TabIndex = 47;
            // 
            // dataGridViewDanhsachlop
            // 
            this.dataGridViewDanhsachlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhsachlop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malop,
            this.tenlop,
            this.tennganh});
            this.dataGridViewDanhsachlop.Location = new System.Drawing.Point(104, 237);
            this.dataGridViewDanhsachlop.Name = "dataGridViewDanhsachlop";
            this.dataGridViewDanhsachlop.RowHeadersWidth = 51;
            this.dataGridViewDanhsachlop.RowTemplate.Height = 24;
            this.dataGridViewDanhsachlop.Size = new System.Drawing.Size(678, 159);
            this.dataGridViewDanhsachlop.TabIndex = 46;
            this.dataGridViewDanhsachlop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhsachlop_CellClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(685, 156);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(115, 40);
            this.btnLamMoi.TabIndex = 41;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(487, 156);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 40);
            this.btnTimKiem.TabIndex = 42;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(352, 156);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 40);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(217, 156);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 40);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(82, 156);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 40);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(439, 55);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(306, 22);
            this.txtTenlop.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tên lớp:";
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(156, 55);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.ReadOnly = true;
            this.txtMalop.Size = new System.Drawing.Size(164, 22);
            this.txtMalop.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tên ngành: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã lớp: ";
            // 
            // tennganh
            // 
            this.tennganh.HeaderText = "Tên ngành";
            this.tennganh.MinimumWidth = 6;
            this.tennganh.Name = "tennganh";
            this.tennganh.Width = 250;
            // 
            // tenlop
            // 
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.MinimumWidth = 6;
            this.tenlop.Name = "tenlop";
            this.tenlop.Width = 250;
            // 
            // malop
            // 
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 125;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.comboBoxDanhsachnganh);
            this.Controls.Add(this.dataGridViewDanhsachlop);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenlop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmLop";
            this.Text = "Quản lý lớp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLop_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhsachlop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDanhsachnganh;
        private System.Windows.Forms.DataGridView dataGridViewDanhsachlop;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennganh;
    }
}