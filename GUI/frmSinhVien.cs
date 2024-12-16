    using System;
    using System.Windows.Forms;
    using BLL;
    using DTO;

    namespace GUI {
        public partial class frmSinhVien : Form {
            private SinhVienBLL _sinhVienBLL;

            public frmSinhVien() {
                InitializeComponent();
                _sinhVienBLL = new SinhVienBLL();
                SetupDataGridView();
                LoadSinhVienData();
                LoadComboBoxData();
                tlpSearch.Visible = false;
                btnSearch.Visible = false;
                btnSearch.Click += btnSearch_Click;
        }

        // Cài đặt thuộc tính cho DataGridView
        private void SetupDataGridView() {
                dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSinhVien.MultiSelect = false; // Không cho phép chọn nhiều dòng
                dgvSinhVien.ReadOnly = true; // Dữ liệu chỉ đọc
                dgvSinhVien.AllowUserToAddRows = false; // Không cho phép thêm hàng trống
            }

            // Load dữ liệu sinh viên lên DataGridView
            private void LoadSinhVienData() {
                dgvSinhVien.Rows.Clear();
                try
                {
                    var sinhViens = _sinhVienBLL.GetAllSinhViens();
                    foreach (var sv in sinhViens)
                    {
                        dgvSinhVien.Rows.Add(
                            sv.MSSV, sv.FullName, sv.BirthYear, sv.Sex, sv.Email,
                            sv.PhoneNum, sv.Class, sv.Major, sv.Faculty, sv.Session, sv.Advisor
                        );
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu sinh viên: {ex.Message}");
                }
            }

            // Thêm sinh viên mới
            private void btnAdd_Click_1(object sender, EventArgs e) {
                var form = new ChiTietSinhVien();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSinhVienData();
                }
            }

            // Chỉnh sửa thông tin sinh viên
            private void btnAdjust_Click(object sender, EventArgs e) {
                if (dgvSinhVien.SelectedRows.Count > 0)
                {
                    var row = dgvSinhVien.SelectedRows[0];
                    try
                    {
                        var sinhVien = new SinhVien {
                            MSSV = row.Cells[0].Value.ToString(),
                            FullName = row.Cells[1].Value.ToString(),
                            BirthYear = int.Parse(row.Cells[2].Value.ToString()),
                            Sex = row.Cells[3].Value.ToString(),
                            Email = row.Cells[4].Value.ToString(),
                            PhoneNum = row.Cells[5].Value.ToString(),
                            Class = row.Cells[6].Value.ToString(),
                            Major = row.Cells[7].Value.ToString(),
                            Faculty = row.Cells[8].Value.ToString(),
                            Session = row.Cells[9].Value.ToString(),
                            Advisor = row.Cells[10].Value.ToString()
                        };

                        var form = new ChiTietSinhVien(sinhVien);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            LoadSinhVienData();
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi chỉnh sửa sinh viên: {ex.Message}");
                    }
                } else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để chỉnh sửa.");
                }
            }

            // Xóa sinh viên
            private void btnDelete_Click_1(object sender, EventArgs e) {
                if (dgvSinhVien.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            var mssv = dgvSinhVien.SelectedRows[0].Cells[0].Value.ToString();
                            _sinhVienBLL.DeleteSinhVien(mssv);
                            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo");
                            LoadSinhVienData();
                        } catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi xóa sinh viên: {ex.Message}");
                        }
                    }
                } else
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
                }
            }

            private void btnAdvancedSearch_Click(object sender, EventArgs e) {
                if(tlpSearch.Visible == false ) {
                    tlpSearch.Visible = true;
                    btnSearch.Visible = true;
                } else
                {
                    tlpSearch.Visible = false;
                    btnSearch.Visible = false;
                }
            }

            private void btnSearch_Click(object sender, EventArgs e) {

            // Lấy các giá trị từ các trường tìm kiếm
            string mssv = txtMSSV.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phoneNum = txtPhoneNum.Text.Trim();
            int? birthYear = null;

            // Kiểm tra nếu có giá trị Năm sinh được chọn
            if (!string.IsNullOrEmpty(cbBirthYear.SelectedItem?.ToString()))
            {
                birthYear = int.Parse(cbBirthYear.SelectedItem.ToString());
            }

            string sex = cbSex.SelectedItem?.ToString();
            string className = cbCLass.SelectedItem?.ToString();
            string major = cbMajor.SelectedItem?.ToString();
            string faculty = cbFaculty.SelectedItem?.ToString();
            string session = cbSession.SelectedItem?.ToString();
            string advisor = txtAdvisor.Text.Trim();

            // Tạo bộ lọc cho tìm kiếm
            var filter = new SinhVienFilter {
                MSSV = mssv,
                FullName = fullName,
                Email = email,
                PhoneNum = phoneNum,
                BirthYear = birthYear,
                Sex = sex,
                Class = className,
                Major = major,
                Faculty = faculty,
                Session = session,
                Advisor = advisor
            };

            // Lọc danh sách sinh viên
            var filteredSinhViens = _sinhVienBLL.SearchSinhViens(filter);

            // Hiển thị kết quả tìm kiếm lên DataGridView
            dgvSinhVien.Rows.Clear();
            foreach (var sv in filteredSinhViens)
            {
                dgvSinhVien.Rows.Add(
                    sv.MSSV, sv.FullName, sv.BirthYear, sv.Sex, sv.Email,
                    sv.PhoneNum, sv.Class, sv.Major, sv.Faculty, sv.Session, sv.Advisor
                );
            }
        }

        // Load dữ liệu cho ComboBox
        private void LoadComboBoxData() {
            MessageBox.Show("Đang tải dữ liệu ComboBox...");
            // Load dữ liệu cho cbSex (Giới tính
            cbSex.Items.AddRange(new string[] { "Nam", "Nữ" });
            cbBirthYear.Items.Clear();
          
            // Năm sinh từ 1980 - 2024
            for (int year = 1980; year <= 2024; year++)
            {
                cbBirthYear.Items.Add(year.ToString());
            }

            // Lớp, Ngành, Khoa, và Khóa học (Ví dụ, bạn có thể thay thế bằng dữ liệu thực tế)
            cbCLass.Items.AddRange(new string[] { "DCT122C4", "DCT122C3", "DCT121B2" });
            cbMajor.Items.AddRange(new string[] { "Công nghệ thông tin", "Quản trị kinh doanh", "Kỹ thuật phần mềm" });
            cbFaculty.Items.AddRange(new string[] { "Khoa CNTT", "Khoa Kinh tế", "Khoa Điện tử" });
            cbSession.Items.AddRange(new string[] { "2022-2027", "2021-2026", "2020-2025" });
        }

    }
}
