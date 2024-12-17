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
    public partial class frmLop : Form
    {
        private readonly LopBLL _logic;

        public frmLop()
        {
            InitializeComponent();
            _logic = new LopBLL();
            LoadData();
        }

        private void LoadData()
        {
            // Tắt tự động tạo cột để không làm xuất hiện cột mới
            dataGridViewDanhsachlop.AutoGenerateColumns = false;

            // Lấy dữ liệu từ nguồn
            var data = _logic.GetLops()
                .Select(l => new
                {
                    l.MaLop,
                    l.tenLop,
                    TenNganh = _logic.GetNganhs().FirstOrDefault(n => n.maNganh == l.nganhId)?.tenNganh
                })
                .ToList();

            // Gán dữ liệu cho DataGridView
            dataGridViewDanhsachlop.DataSource = data;

            // Đảm bảo các cột trong DataGridView sử dụng đúng tên cột
            dataGridViewDanhsachlop.Columns["malop"].DataPropertyName = "MaLop";
            dataGridViewDanhsachlop.Columns["tenlop"].DataPropertyName = "tenLop";
            dataGridViewDanhsachlop.Columns["tennganh"].DataPropertyName = "TenNganh";

            // Gán dữ liệu cho ComboBox
            comboBoxDanhsachnganh.DataSource = _logic.GetNganhs();
            comboBoxDanhsachnganh.DisplayMember = "TenNganh";
            comboBoxDanhsachnganh.ValueMember = "maNganh";
            comboBoxDanhsachnganh.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var newLop = new Lop
            {
                MaLop = txtMalop.Text,
                tenLop = txtTenlop.Text,
                nganhId = comboBoxDanhsachnganh.SelectedValue.ToString()
            };

            _logic.AddLop(newLop);
            LoadData();
            MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhsachlop.SelectedRows.Count > 0)
            {
                var maLop = dataGridViewDanhsachlop.SelectedRows[0].Cells["malop"].Value.ToString();
                var updatedLop = new Lop
                {
                    MaLop = maLop,
                    tenLop = txtTenlop.Text,
                    nganhId = comboBoxDanhsachnganh.SelectedValue.ToString()
                };

                _logic.UpdateLop(updatedLop);
                LoadData();
                MessageBox.Show("Cập nhật lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewDanhsachlop.SelectedRows.Count > 0)
            {
                var maLop = dataGridViewDanhsachlop.SelectedRows[0].Cells["malop"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc muốn xóa lớp học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _logic.DeleteLop(maLop);
                    LoadData();
                    MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tenLop = txtTenlop.Text.Trim();
            var idNganh = comboBoxDanhsachnganh.SelectedValue?.ToString();

            var result = _logic.SearchLops(tenLop, idNganh)
                .Select(l => new { l.MaLop, l.tenLop, TenNganh = _logic.GetNganhs().FirstOrDefault(n => n.maNganh == l.nganhId)?.tenNganh })
                .ToList();

            if (result.Any())
            {
                dataGridViewDanhsachlop.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy lớp nào khớp với tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMalop.Clear();
            txtTenlop.Clear();
            comboBoxDanhsachnganh.SelectedIndex = -1; // Đặt về trạng thái không chọn ngành
            LoadData();
        }

        private void dataGridViewDanhsachlop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewDanhsachlop.Rows[e.RowIndex];
                txtMalop.Text = selectedRow.Cells["malop"].Value.ToString();
                txtTenlop.Text = selectedRow.Cells["tenlop"].Value.ToString();

                // Thiết lập ngành theo ID
                var tenNganh = selectedRow.Cells["tennganh"].Value.ToString();
                var nganh = _logic.GetNganhs().FirstOrDefault(n => n.tenNganh == tenNganh);
                if (nganh != null)
                {
                    comboBoxDanhsachnganh.SelectedValue = nganh.maNganh;
                }
            }
        }

        private void frmLop_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
