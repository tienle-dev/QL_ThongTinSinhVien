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
    public partial class frmKhoa : Form
    {
        private readonly KhoaBLL _logic;
        public frmKhoa()
        {
            InitializeComponent();
            _logic = new KhoaBLL();
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewDanhsachkhoa.AutoGenerateColumns = false;
            var data = _logic.GetKhoas()
                .Select(k => new
                {
                    k.maKhoa,
                    k.tenKhoa
                })
                .ToList();
            dataGridViewDanhsachkhoa.DataSource = data;

            // Đảm bảo cột sử dụng đúng tên
            dataGridViewDanhsachkhoa.Columns["makhoa"].DataPropertyName = "maKhoa";
            dataGridViewDanhsachkhoa.Columns["tenkhoa"].DataPropertyName = "tenKhoa";
        }
        private void dataGridViewDanhsachkhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng hợp lệ hay không
            if (e.RowIndex >= 0 && dataGridViewDanhsachkhoa.Rows[e.RowIndex].Cells["makhoa"].Value != null)
            {
                // Lấy giá trị của các ô trong dòng được chọn
                var selectedRow = dataGridViewDanhsachkhoa.Rows[e.RowIndex];

                // Gán giá trị từ ô vào các textbox
                txtMakhoa.Text = selectedRow.Cells["makhoa"].Value.ToString();
                txtTenkhoa.Text = selectedRow.Cells["tenkhoa"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var newKhoa = new Khoa
            {
                maKhoa = txtMakhoa.Text.Trim(),
                tenKhoa = txtTenkhoa.Text.Trim()
            };

            _logic.AddKhoa(newKhoa);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhsachkhoa.SelectedRows.Count > 0)
            {
                var maKhoa = dataGridViewDanhsachkhoa.SelectedRows[0].Cells["makhoa"].Value.ToString();
                var updatedKhoa = new Khoa
                {
                    maKhoa = maKhoa,
                    tenKhoa = txtTenkhoa.Text.Trim()
                };

                _logic.UpdateKhoa(updatedKhoa);
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhsachkhoa.SelectedRows.Count > 0)
            {
                var maKhoa = dataGridViewDanhsachkhoa.SelectedRows[0].Cells["makhoa"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _logic.DeleteKhoa(maKhoa);
                    LoadData();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var searchTerm = txtTenkhoa.Text.Trim();  // Lấy giá trị tìm kiếm từ ô nhập liệu

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                // Gọi phương thức tìm kiếm từ lớp BLL
                var result = _logic.SearchKhoas(searchTerm)
                    .Select(k => new
                    {
                        k.maKhoa,
                        k.tenKhoa
                    })
                    .ToList();

                if (result.Any())
                {
                    dataGridViewDanhsachkhoa.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khoa khớp với tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Nếu không có từ khóa tìm kiếm, load lại toàn bộ danh sách khoa
                LoadData();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMakhoa.Clear();
            txtTenkhoa.Clear();
            LoadData();
        }


        private void dataGridViewDanhsachkhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            dataGridViewDanhsachkhoa.AutoGenerateColumns = false;
            var data = _logic.GetKhoas()
                .Select(k => new
                {
                    k.maKhoa,
                    k.tenKhoa
                })
                .ToList();
            dataGridViewDanhsachkhoa.DataSource = data;

            // Đảm bảo cột sử dụng đúng tên
            dataGridViewDanhsachkhoa.Columns["makhoa"].DataPropertyName = "maKhoa";
            dataGridViewDanhsachkhoa.Columns["tenkhoa"].DataPropertyName = "tenKhoa";
        }

        private void txtMakhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
