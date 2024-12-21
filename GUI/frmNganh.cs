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
                                 Khoa = _logic.GetKhoaById(n.maKhoa)?.tenKhoa ?? "Chưa có khoa" // Hiển thị tên khoa nếu có, nếu không thì hiển thị "Chưa có khoa"
                             })
                             .ToList();

            dataGridViewDanhsachnganh.DataSource = data;

            // Đảm bảo cột sử dụng đúng tên
            dataGridViewDanhsachnganh.Columns["manganh"].DataPropertyName = "maNganh";
            dataGridViewDanhsachnganh.Columns["tennganh"].DataPropertyName = "tenNganh";
            dataGridViewDanhsachnganh.Columns["tenkhoa"].DataPropertyName = "Khoa"; // Gán tên khoa vào cột
        }

        private void frmNganh_Load(object sender, EventArgs e)
        {
            // Lấy danh sách các khoa từ BLL
            var khoas = _logic.GetKhoas();

            // Nạp dữ liệu vào ComboBox
            comboBoxDanhsachkhoa.DataSource = khoas;
            comboBoxDanhsachkhoa.DisplayMember = "tenKhoa";  // Hiển thị tên khoa trong ComboBox
            comboBoxDanhsachkhoa.ValueMember = "Id";         // Giá trị của ComboBox là Id khoa

            // Đảm bảo ComboBox có giá trị hợp lệ
            if (comboBoxDanhsachkhoa.Items.Count > 0)
                comboBoxDanhsachkhoa.SelectedIndex = 0;  // Chọn khoa đầu tiên nếu có dữ liệu
                                                         // Bạn không cần gọi LoadComboBoxKhoas() ở đây nữa vì đã thực hiện rồi
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
            // Kiểm tra xem người dùng đã chọn một khoa trong ComboBox chưa
            if (comboBoxDanhsachkhoa.SelectedValue != null)
            {
                var newNganh = new Nganh
                {
                    maNganh = txtManganh.Text.Trim(),
                    tenNganh = txtTennganh.Text.Trim(),
                    maKhoa = comboBoxDanhsachkhoa.SelectedValue.ToString() // Truy xuất giá trị khoaId từ ComboBox
                };

                // Thêm ngành mới
                _logic.AddNganh(newNganh);

                // Load lại dữ liệu
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khoa trước khi thêm ngành!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhsachnganh.SelectedRows.Count > 0)
            {
                var maNganh = dataGridViewDanhsachnganh.SelectedRows[0].Cells["maNganh"].Value.ToString();
                string khoaId = null;

                // Kiểm tra nếu ComboBox có giá trị được chọn
                if (comboBoxDanhsachkhoa.SelectedValue != null)
                {
                    khoaId = comboBoxDanhsachkhoa.SelectedValue.ToString();  // Lấy khoaId từ ComboBox
                }
                else
                {
                    // Nếu không có giá trị khoaId được chọn, bạn có thể hiển thị thông báo lỗi hoặc xử lý khác
                    MessageBox.Show("Vui lòng chọn một khoa trước khi lưu thay đổi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // Dừng thực thi nếu không có khoaId hợp lệ
                }

                var updatedNganh = new Nganh
                {
                    maNganh = maNganh,
                    tenNganh = txtTennganh.Text.Trim(),
                    maKhoa = khoaId // Gán khoaId vào đối tượng
                };

                _logic.UpdateNganh(updatedNganh);  // Cập nhật ngành
                LoadData();  // Nạp lại dữ liệu vào DataGridView
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
            // Lấy giá trị tìm kiếm từ các trường nhập liệu (mã ngành, tên ngành, tên khoa)
            var searchManganh = txtManganh.Text.Trim();
            var searchTennganh = txtTennganh.Text.Trim();
            var searchKhoa = comboBoxDanhsachkhoa.SelectedValue?.ToString();

            // Nếu có ít nhất một trường tìm kiếm có giá trị
            if (!string.IsNullOrWhiteSpace(searchManganh) || !string.IsNullOrWhiteSpace(searchTennganh) || !string.IsNullOrWhiteSpace(searchKhoa))
            {
                // Thực hiện tìm kiếm trong BLL
                var result = _logic.SearchNganhs(searchManganh, searchTennganh, searchKhoa)
                    .Select(n => new
                    {
                        n.maNganh,
                        n.tenNganh,
                        Khoa = _logic.GetKhoaById(n.maKhoa)?.tenKhoa ?? "Chưa có khoa"
                    })
                    .ToList();

                // Kiểm tra nếu có kết quả
                if (result.Any())
                {
                    dataGridViewDanhsachnganh.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Nếu không có kết quả, hiển thị lại tất cả dữ liệu
                }
            }
            else
            {
                // Nếu không có giá trị tìm kiếm, nạp lại dữ liệu đầy đủ
                LoadData();
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
            comboBoxDanhsachkhoa.DataSource = khoas;
            comboBoxDanhsachkhoa.DisplayMember = "tenKhoa";  // Cột hiển thị tên khoa
            comboBoxDanhsachkhoa.ValueMember = "Id";         // Cột giá trị là Id của khoa
        }
        private void dataGridViewDanhsachnganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ không
            if (e.RowIndex >= 0)  // Kiểm tra nếu RowIndex không âm (dòng hợp lệ)
            {
                // Lấy dòng được chọn
                var selectedRow = dataGridViewDanhsachnganh.Rows[e.RowIndex];

                // Kiểm tra giá trị của các ô trước khi gán vào các textbox và comboBox
                if (selectedRow.Cells["maNganh"].Value != null)
                    txtManganh.Text = selectedRow.Cells["maNganh"].Value.ToString();

                if (selectedRow.Cells["tenNganh"].Value != null)
                    txtTennganh.Text = selectedRow.Cells["tenNganh"].Value.ToString();

                // Sửa tên cột từ "Khoa" thành "tenkhoa"
                if (selectedRow.Cells["tenkhoa"].Value != null)
                {
                    var khoaId = selectedRow.Cells["tenkhoa"].Value.ToString();  // Lấy giá trị khoa từ cột "tenkhoa"
                    comboBoxDanhsachkhoa.SelectedValue = khoaId;  // Chọn khoa theo khoaId
                }
            }
        }
        private void dataGridViewDanhsachnganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
