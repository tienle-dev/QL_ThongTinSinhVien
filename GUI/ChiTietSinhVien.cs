using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI {
    public partial class ChiTietSinhVien : Form {
        private SinhVienBLL _sinhVienBLL;
        private SinhVien _currentSinhVien;

        public ChiTietSinhVien(SinhVien sinhVien = null) {
            InitializeComponent();
            _sinhVienBLL = new SinhVienBLL();
            _currentSinhVien = sinhVien;

            // Load dữ liệu cho ComboBox
            LoadComboBoxData();

            if (_currentSinhVien != null)
            {
                // Chỉnh sửa: Load thông tin sinh viên
                txtMSSV.Text = _currentSinhVien.MSSV;
                txtFullName.Text = _currentSinhVien.FullName;

                // Giới tính
                if (_currentSinhVien.Sex == "Nam") rdbMale.Checked = true;
                else rdbFemale.Checked = true;

                // ComboBox
                cbBirthYear.Text = _currentSinhVien.BirthYear.ToString();
                cbClass.Text = _currentSinhVien.Class;
                cbMajor.Text = _currentSinhVien.Major;
                cbFaculty.Text = _currentSinhVien.Faculty;
                cbSession.Text = _currentSinhVien.Session;
                txtEmail.Text = _currentSinhVien.Email;
                txtPhoneNum.Text = _currentSinhVien.PhoneNum;
                txtAdvisor.Text = _currentSinhVien.Advisor;
            }
        }

        private void LoadComboBoxData() {
            // Năm sinh từ 1980 - 2024
            for (int year = 1980; year <= 2024; year++)
            {
                cbBirthYear.Items.Add(year.ToString());
            }

            // Lớp, Ngành, Khoa, và Khóa học (Ví dụ, bạn có thể thay thế bằng dữ liệu thực tế)
            cbClass.Items.AddRange(new string[] { "DCT122C4", "DCT122C3", "DCT121B2" });
            cbMajor.Items.AddRange(new string[] { "Công nghệ thông tin", "Quản trị kinh doanh", "Kỹ thuật phần mềm" });
            cbFaculty.Items.AddRange(new string[] { "Khoa CNTT", "Khoa Kinh tế", "Khoa Điện tử" });
            cbSession.Items.AddRange(new string[] { "2022-2027", "2021-2026", "2020-2025" });
        }

       
        //Lưu sinh viên
        private void btnSave_Click_1(object sender, EventArgs e) {
            // Lấy giới tính từ RadioButton
            string sex = rdbMale.Checked ? "Nam" : "Nữ";

            var sinhVien = new SinhVien {
                MSSV = txtMSSV.Text,
                FullName = txtFullName.Text,
                BirthYear = int.Parse(cbBirthYear.Text),
                Sex = sex,
                Email = txtEmail.Text,
                PhoneNum = txtPhoneNum.Text,
                Class = cbClass.Text,
                Major = cbMajor.Text,
                Faculty = cbFaculty.Text,
                Session = cbSession.Text,
                Advisor = txtAdvisor.Text
            };

            if (_currentSinhVien == null)
            {
                _sinhVienBLL.AddSinhVien(sinhVien);
                MessageBox.Show("Thêm sinh viên thành công!");
            } else
            {
                _sinhVienBLL.UpdateSinhVien(_currentSinhVien.MSSV, sinhVien);
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Hủy thao tác
        private void btnCancel_Click(object sender, EventArgs e) {
            // Nếu bạn muốn chắc chắn người dùng có muốn hủy không, bạn có thể hiển thị một hộp thoại xác nhận
            var result = MessageBox.Show("Bạn có chắc muốn hủy bỏ? Mọi thay đổi sẽ không được lưu.", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes", đóng form mà không lưu dữ liệu
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            // Nếu người dùng chọn "No", không làm gì và form sẽ không đóng
        }
    }
}
