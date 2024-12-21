namespace GUI
{
    partial class frmNganh
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
            this.dataGridViewDanhsachnganh = new System.Windows.Forms.DataGridView();
            this.manganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTennganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManganh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDanhsachkhoa = new System.Windows.Forms.ComboBox();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhsachnganh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhsachnganh
            // 
            this.dataGridViewDanhsachnganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhsachnganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhsachnganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manganh,
            this.tennganh,
            this.tenkhoa});
            this.dataGridViewDanhsachnganh.Location = new System.Drawing.Point(12, 227);
            this.dataGridViewDanhsachnganh.Name = "dataGridViewDanhsachnganh";
            this.dataGridViewDanhsachnganh.RowHeadersWidth = 51;
            this.dataGridViewDanhsachnganh.RowTemplate.Height = 24;
            this.dataGridViewDanhsachnganh.Size = new System.Drawing.Size(1321, 323);
            this.dataGridViewDanhsachnganh.TabIndex = 34;
            this.dataGridViewDanhsachnganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhsachnganh_CellClick);
            this.dataGridViewDanhsachnganh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhsachnganh_CellContentClick);
            // 
            // manganh
            // 
            this.manganh.HeaderText = "Mã ngành";
            this.manganh.MinimumWidth = 6;
            this.manganh.Name = "manganh";
            // 
            // tennganh
            // 
            this.tennganh.HeaderText = "Tên ngành";
            this.tennganh.MinimumWidth = 6;
            this.tennganh.Name = "tennganh";
            // 
            // tenkhoa
            // 
            this.tenkhoa.HeaderText = "Tên khoa";
            this.tenkhoa.MinimumWidth = 6;
            this.tenkhoa.Name = "tenkhoa";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1118, 170);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(115, 40);
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(883, 170);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 40);
            this.btnTimKiem.TabIndex = 30;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(651, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 40);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(421, 170);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 40);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(173, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 40);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTennganh
            // 
            this.txtTennganh.Location = new System.Drawing.Point(927, 75);
            this.txtTennganh.Name = "txtTennganh";
            this.txtTennganh.Size = new System.Drawing.Size(306, 22);
            this.txtTennganh.TabIndex = 27;
            this.txtTennganh.TextChanged += new System.EventHandler(this.txtTennganh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(790, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên ngành:";
            // 
            // txtManganh
            // 
            this.txtManganh.Location = new System.Drawing.Point(173, 73);
            this.txtManganh.Name = "txtManganh";
            this.txtManganh.Size = new System.Drawing.Size(291, 22);
            this.txtManganh.TabIndex = 28;
            this.txtManganh.TextChanged += new System.EventHandler(this.txtManganh_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã ngành: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên khoa: ";
            // 
            // comboBoxDanhsachkhoa
            // 
            this.comboBoxDanhsachkhoa.FormattingEnabled = true;
            this.comboBoxDanhsachkhoa.Location = new System.Drawing.Point(173, 123);
            this.comboBoxDanhsachkhoa.Name = "comboBoxDanhsachkhoa";
            this.comboBoxDanhsachkhoa.Size = new System.Drawing.Size(291, 24);
            this.comboBoxDanhsachkhoa.TabIndex = 35;
            this.comboBoxDanhsachkhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxDanhsachkhoa_SelectedIndexChanged);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaylai.Location = new System.Drawing.Point(37, 19);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(91, 26);
            this.btnQuaylai.TabIndex = 36;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = false;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(527, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 37);
            this.label4.TabIndex = 37;
            this.label4.Text = "Quản lý ngành";
            // 
            // frmNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.comboBoxDanhsachkhoa);
            this.Controls.Add(this.dataGridViewDanhsachnganh);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTennganh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtManganh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmNganh";
            this.Text = "frmNganh";
            this.Load += new System.EventHandler(this.frmNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhsachnganh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhsachnganh;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTennganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManganh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDanhsachkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn manganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoa;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Label label4;
    }
}