using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmGiangvien : Form
    {
        private readonly GiangVienBLL _logic;
        public frmGiangvien()
        {
            InitializeComponent();
            _logic = new GiangVienBLL();
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewBangGV.AutoGenerateColumns = false;
            var data = _logic.GetGiangViens()
                .Select(g => new
                {
                    g.maGV,
                    g.hoTen,
                    g.gioiTinh,
                    g.maLop,
                    g.ngaySinh,
                    g.email,
                    g.soDT
                }).ToList();
            dataGridViewBangGV.DataSource = data;

            // Đảm bảo cột khớp với các thuộc tính trong đối tượng
            dataGridViewBangGV.Columns["magiangvien"].DataPropertyName = "maGV";
            dataGridViewBangGV.Columns["tengiangvien"].DataPropertyName = "hoTen";
            dataGridViewBangGV.Columns["gioitinh"].DataPropertyName = "gioiTinh";
            dataGridViewBangGV.Columns["malop"].DataPropertyName = "maLop";
            dataGridViewBangGV.Columns["ngaysinh"].DataPropertyName = "ngaySinh";
            dataGridViewBangGV.Columns["email"].DataPropertyName = "email";
            dataGridViewBangGV.Columns["sodienthoai"].DataPropertyName = "soDT";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewBangGV.SelectedRows.Count > 0)
            {
                var maGV = dataGridViewBangGV.SelectedRows[0].Cells["maGV"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc muốn xóa giảng viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _logic.DeleteGiangVien(maGV);
                    LoadData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newGV = new GiangVien
            {
                maGV = textBoxMaGV.Text.Trim(),
                hoTen = textBoxTenGV.Text.Trim(),
                gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ",
                maLop = comboBoxMaLop.Text.Trim(),
                ngaySinh = dateTimePickerNgaySinh.Value.ToString("dd/MM/yyyy"),
                email = textBoxEmail.Text.Trim(),
                soDT = textBoxSoDT.Text.Trim()
            };
            _logic.AddGiangVien(newGV);
            LoadData();
        }

        private void textBoxMaGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTenGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSoDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewBangGV.SelectedRows.Count > 0)
            {
                var maGV = dataGridViewBangGV.SelectedRows[0].Cells["maGV"].Value.ToString();
                var updatedGV = new GiangVien
                {
                    maGV = maGV,
                    hoTen = textBoxTenGV.Text.Trim(),
                    gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ",
                    maLop = comboBoxMaLop.Text.Trim(),
                    ngaySinh = dateTimePickerNgaySinh.Value.ToString("dd/MM/yyyy"),
                    email = textBoxEmail.Text.Trim(),
                    soDT = textBoxSoDT.Text.Trim()
                };
                _logic.UpdateGiangVien(updatedGV);
                LoadData();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            textBoxMaGV.Clear();
            textBoxTenGV.Clear();
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            comboBoxMaLop.SelectedIndex = -1;
            dateTimePickerNgaySinh.Value = DateTime.Today;
            textBoxEmail.Clear();
            textBoxSoDT.Clear();
            LoadData();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewBangGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var searchTerm = textBoxTenGV.Text.Trim();
            var result = _logic.SearchGiangViens(searchTerm)
                .Select(g => new
                {
                    g.maGV,
                    g.hoTen,
                    g.gioiTinh,
                    g.maLop,
                    g.ngaySinh,
                    g.email,
                    g.soDT
                }).ToList();
            dataGridViewBangGV.DataSource = result;
        }
        private void LoadMaLopToComboBox()
        {

        }

        private void frmGiangvien_Load(object sender, EventArgs e)
        {

        }
        private void dataGridViewBangGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra tránh lỗi khi click vào tiêu đề cột hoặc ngoài vùng dữ liệu
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridViewBangGV.Rows[e.RowIndex];

                // Kiểm tra và lấy dữ liệu từ các cột với tên đúng từ DataGridView
                // Hiển thị thông tin lên các điều khiển

                // Mã giảng viên
                textBoxMaGV.Text = selectedRow.Cells["magiangvien"]?.Value?.ToString();

                // Tên giảng viên
                textBoxTenGV.Text = selectedRow.Cells["tengiangvien"]?.Value?.ToString();

                // Mã lớp
                comboBoxMaLop.Text = selectedRow.Cells["malop"]?.Value?.ToString();

                // Ngày sinh
                if (selectedRow.Cells["ngaysinh"]?.Value != null)
                {
                    dateTimePickerNgaySinh.Value = Convert.ToDateTime(selectedRow.Cells["ngaysinh"].Value);
                }

                // Xử lý giới tính (Nam/Nữ)
                string gioiTinh = selectedRow.Cells["gioitinh"]?.Value?.ToString();
                if (gioiTinh == "Nam")
                {
                    radioButtonNam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    radioButtonNu.Checked = true;
                }

                // Email
                textBoxEmail.Text = selectedRow.Cells["email"]?.Value?.ToString();

                // Số điện thoại
                textBoxSoDT.Text = selectedRow.Cells["sodienthoai"]?.Value?.ToString();
            }
        }

    }
}

