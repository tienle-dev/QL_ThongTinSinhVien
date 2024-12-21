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
    public partial class frmNganh : Form
    {
        private readonly NganhBLL _logic;
        public frmNganh()
        {
            InitializeComponent();
            _logic = new NganhBLL();
            LoadData();
            LoadComboBoxKhoas();
        }
        // Load dữ liệu vào DataGridView
        private void LoadData()
        {
            dataGridViewDanhsachnganh.AutoGenerateColumns = false;

            var data = _logic.GetNganhs()
                             .Select(n => new
                             {
                                 n.maNganh,
                                 n.tenNganh,
                                 Khoa = n.maKhoa // Hiển thị trực tiếp tên khoa
                             })
                             .ToList();

            dataGridViewDanhsachnganh.DataSource = data;

            // Gán cột
            dataGridViewDanhsachnganh.Columns["manganh"].DataPropertyName = "maNganh";
            dataGridViewDanhsachnganh.Columns["tennganh"].DataPropertyName = "tenNganh";
            dataGridViewDanhsachnganh.Columns["tenkhoa"].DataPropertyName = "Khoa";

            comboBoxDanhsachkhoa.DataSource = _logic.GetKhoas();
            comboBoxDanhsachkhoa.DisplayMember = "tenKhoa";
            comboBoxDanhsachkhoa.ValueMember = "maKhoa";
            comboBoxDanhsachkhoa.SelectedIndex = -1;
        }

        private void frmNganh_Load(object sender, EventArgs e)
        {
            // Lấy danh sách các khoa từ BLL
            var khoas = _logic.GetKhoas();

            // Nạp dữ liệu vào ComboBox
            comboBoxDanhsachkhoa.DataSource = khoas;
            comboBoxDanhsachkhoa.DisplayMember = "tenKhoa";  // Hiển thị tên khoa trong ComboBox
            comboBoxDanhsachkhoa.ValueMember = "Id";         // Giá trị của ComboBox là Id khoa
            LoadComboBoxKhoas();

        }

        private void txtManganh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTennganh_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDanhsachkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy tên khoa từ ComboBox
            var selectedKhoa = comboBoxDanhsachkhoa.Text.Trim(); // Lấy tên khoa trực tiếp từ DisplayMember
            if (string.IsNullOrEmpty(selectedKhoa))
            {
                MessageBox.Show("Vui lòng chọn một khoa trước khi thêm ngành!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng ngành mới
            var newNganh = new Nganh
            {
                maNganh = txtManganh.Text.Trim(),
                tenNganh = txtTennganh.Text.Trim(),
                maKhoa = selectedKhoa // Gán tên khoa từ ComboBox
            };

            // Thêm ngành vào database thông qua BLL
            _logic.AddNganh(newNganh);

            // Tải lại dữ liệu để hiển thị ngành mới
            LoadData();

            // Thông báo thêm thành công
            MessageBox.Show("Thêm ngành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhsachnganh.SelectedRows.Count > 0)
            {
                // Lấy mã ngành của dòng được chọn
                var maNganh = dataGridViewDanhsachnganh.SelectedRows[0].Cells["maNganh"].Value.ToString();

                // Lấy thông tin tên ngành từ TextBox
                var tenNganh = txtTennganh.Text.Trim();

                // Lấy tên khoa từ ComboBox
                var selectedKhoa = comboBoxDanhsachkhoa.Text.Trim(); // Lấy tên khoa từ DisplayMember
                if (string.IsNullOrEmpty(selectedKhoa))
                {
                    MessageBox.Show("Vui lòng chọn một khoa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật ngành
                var updatedNganh = new Nganh
                {
                    maNganh = maNganh,
                    tenNganh = tenNganh,
                    maKhoa = selectedKhoa // Gán tên khoa
                };

                // Gọi BLL để cập nhật ngành
                _logic.UpdateNganh(updatedNganh);

                // Tải lại dữ liệu sau khi sửa
                LoadData();

                // Thông báo sửa thành công
                MessageBox.Show("Sửa ngành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhsachnganh.SelectedRows.Count > 0)
            {
                // Lấy mã ngành từ cột "manganh"
                var maNganh = dataGridViewDanhsachnganh.SelectedRows[0].Cells["manganh"].Value.ToString();

                // Xác nhận người dùng có chắc chắn muốn xóa
                if (MessageBox.Show("Bạn có chắc muốn xóa ngành này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Xóa ngành
                    _logic.DeleteNganh(maNganh);
                    // Nạp lại dữ liệu vào DataGridView
                    LoadData();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var searchManganh = txtManganh.Text.Trim();
            var searchTennganh = txtTennganh.Text.Trim();

            // Lấy giá trị khoa từ ComboBox
            var searchKhoa = comboBoxDanhsachkhoa.SelectedValue != null
                             ? comboBoxDanhsachkhoa.Text.Trim()
                             : null;

            var result = _logic.SearchNganhs(searchManganh, searchTennganh, searchKhoa)
                               .Select(n => new
                               {
                                   n.maNganh,
                                   n.tenNganh,
                                   Khoa = n.maKhoa // Hiển thị tên khoa
                               })
                               .ToList();

            if (result.Any())
            {
                dataGridViewDanhsachnganh.DataSource = result;
                comboBoxDanhsachkhoa.SelectedIndex = -1; // Không chọn gì khi tìm thấy kết quả
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Tải lại toàn bộ dữ liệu nếu không có kết quả
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtManganh.Clear();
            txtTennganh.Clear();
            comboBoxDanhsachkhoa.SelectedIndex = -1;
            LoadData();
        }
        private void LoadComboBoxKhoas()
        {
            var khoas = _logic.GetKhoas(); // Lấy danh sách khoa từ BLL

            // Thêm một mục "Chọn khoa" vào đầu danh sách ComboBox
            var defaultKhoa = new Khoa { maKhoa = "", tenKhoa = "Chọn khoa" }; // Khoa trống
            khoas.Insert(0, defaultKhoa); // Thêm vào đầu danh sách

            comboBoxDanhsachkhoa.DataSource = khoas;
            comboBoxDanhsachkhoa.DisplayMember = "tenKhoa";  // Cột hiển thị tên khoa
            comboBoxDanhsachkhoa.ValueMember = "maKhoa";     // Cột giá trị là maKhoa

            // Đảm bảo ComboBox không chọn khoa đầu tiên (Chọn khoa)
            comboBoxDanhsachkhoa.SelectedIndex = 0; // Chọn mục "Chọn khoa"
        }
        private void dataGridViewDanhsachnganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewDanhsachnganh.Rows[e.RowIndex];

                // Hiển thị mã ngành
                if (selectedRow.Cells["maNganh"].Value != null)
                    txtManganh.Text = selectedRow.Cells["maNganh"].Value.ToString();

                // Hiển thị tên ngành
                if (selectedRow.Cells["tenNganh"].Value != null)
                    txtTennganh.Text = selectedRow.Cells["tenNganh"].Value.ToString();

                // Hiển thị tên khoa trong ComboBox
                if (selectedRow.Cells["tenKhoa"].Value != null)
                {
                    var khoaName = selectedRow.Cells["tenKhoa"].Value.ToString();
                    comboBoxDanhsachkhoa.SelectedIndex = comboBoxDanhsachkhoa.FindStringExact(khoaName);
                }
            }
        }
        private void dataGridViewDanhsachnganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
