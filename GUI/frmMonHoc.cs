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
    public partial class frmMonHoc : Form
    {
        private BusinessLogic _logic;
        public frmMonHoc()
        {
            InitializeComponent();
            _logic = new BusinessLogic();
            LoadData();
        }

        private void LoadData()
        {
            // Tắt tự động tạo cột để không làm xuất hiện cột mới
            dataGridViewDanhsachmon.AutoGenerateColumns = false;

            var data = _logic.GetMonHocs()
                .Select(mh => new
                {
                    mh.MaMon,
                    mh.tenMon,
                    mh.soTinChi,
                    mh.tietLT,
                    mh.tietTH,
                    Khoa = _logic.GetKhoas().FirstOrDefault(k => k.maKhoa == mh.khoaId)?.tenKhoa
                }).ToList();

            dataGridViewDanhsachmon.DataSource = data;

            // Đảm bảo các cột trong DataGridView sử dụng đúng tên cột
            dataGridViewDanhsachmon.Columns["mamon"].DataPropertyName = "MaMon";
            dataGridViewDanhsachmon.Columns["tenmon"].DataPropertyName = "tenMon";
            dataGridViewDanhsachmon.Columns["sotinchi"].DataPropertyName = "soTinChi";
            dataGridViewDanhsachmon.Columns["tietlythuyet"].DataPropertyName = "tietLT";
            dataGridViewDanhsachmon.Columns["tietthuchanh"].DataPropertyName = "tietTH";
            dataGridViewDanhsachmon.Columns["khoa"].DataPropertyName = "Khoa";

            comboBoxKhoaquanly.DataSource = _logic.GetKhoas();
            comboBoxKhoaquanly.DisplayMember = "tenKhoa";
            comboBoxKhoaquanly.ValueMember = "maKhoa";
            comboBoxKhoaquanly.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var monHoc = new MonHoc
                {
                    MaMon = txtMamon.Text.Trim(),
                    tenMon = txtTenmon.Text.Trim(),
                    soTinChi = int.Parse(comboBoxTinchi.Text),
                    tietLT = int.Parse(txtTietlythuyet.Text.Trim()),
                    tietTH = int.Parse(txtTietthuchanh.Text.Trim()),
                    khoaId = comboBoxKhoaquanly.SelectedValue.ToString()
                };

                try
                {
                    _logic.AddMonHoc(monHoc);
                    LoadData();
                    MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewDanhsachmon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewDanhsachmon.Rows[e.RowIndex];

                txtMamon.Text = selectedRow.Cells["mamon"].Value.ToString();
                txtTenmon.Text = selectedRow.Cells["tenmon"].Value.ToString();
                comboBoxTinchi.Text = selectedRow.Cells["sotinchi"].Value.ToString();
                txtTietlythuyet.Text = selectedRow.Cells["tietlythuyet"].Value.ToString();
                txtTietthuchanh.Text = selectedRow.Cells["tietthuchanh"].Value.ToString();

                var tenKhoa = selectedRow.Cells["khoa"].Value.ToString();
                var khoa = _logic.GetKhoas().FirstOrDefault(k => k.tenKhoa == tenKhoa);
                if (khoa != null)
                {
                    comboBoxKhoaquanly.SelectedValue = khoa.maKhoa;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var monHoc = new MonHoc
                {
                    MaMon = txtMamon.Text.Trim(),
                    tenMon = txtTenmon.Text.Trim(),
                    soTinChi = int.Parse(comboBoxTinchi.Text),
                    tietLT = int.Parse(txtTietlythuyet.Text.Trim()),
                    tietTH = int.Parse(txtTietthuchanh.Text.Trim()),
                    khoaId = comboBoxKhoaquanly.SelectedValue.ToString()
                };

                try
                {
                    _logic.UpdateMonHoc(monHoc);
                    LoadData();
                    MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMamon.Text))
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _logic.DeleteMonHoc(txtMamon.Text.Trim());
                        LoadData();
                        MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa môn học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tenMon = txtTenmon.Text.Trim();
            var soTinChi = string.IsNullOrWhiteSpace(comboBoxTinchi.Text) ? (int?)null : int.Parse(comboBoxTinchi.Text);
            var tietLyThuyet = string.IsNullOrWhiteSpace(txtTietlythuyet.Text) ? (int?)null : int.Parse(txtTietlythuyet.Text);
            var tietThucHanh = string.IsNullOrWhiteSpace(txtTietthuchanh.Text) ? (int?)null : int.Parse(txtTietthuchanh.Text);
            var maKhoa = comboBoxKhoaquanly.SelectedValue?.ToString();

            var result = _logic.SearchMonHocs(tenMon, soTinChi, tietLyThuyet, tietThucHanh, maKhoa)
                .Select(mh => new
                {
                    mh.MaMon,
                    mh.tenMon,
                    mh.soTinChi,
                    mh.tietLT,
                    mh.tietTH,
                    Khoa = _logic.GetKhoas().FirstOrDefault(k => k.maKhoa == mh.khoaId)?.tenKhoa
                }).ToList();

            if (result.Any())
            {
                dataGridViewDanhsachmon.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMamon.Clear();
            txtTenmon.Clear();
            comboBoxTinchi.SelectedIndex = -1;
            txtTietlythuyet.Clear();
            txtTietthuchanh.Clear();
            comboBoxKhoaquanly.SelectedIndex = -1;
            LoadData();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtMamon.Text) || string.IsNullOrWhiteSpace(txtTenmon.Text) || comboBoxTinchi.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtTietlythuyet.Text) || string.IsNullOrWhiteSpace(txtTietthuchanh.Text) || comboBoxKhoaquanly.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtTietlythuyet.Text, out _) || !int.TryParse(txtTietthuchanh.Text, out _))
            {
                MessageBox.Show("Số tiết lý thuyết và thực hành phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void frmMonHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
