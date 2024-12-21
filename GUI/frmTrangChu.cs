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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void SinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSinhVien sinhvien = new frmSinhVien();
            sinhvien.ShowDialog();
            this.Show();
        }

        private void MonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMonHoc monHoc = new frmMonHoc();
            monHoc.ShowDialog();
            this.Show();
        }

        private void DiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiem diem = new frmDiem();
            diem.ShowDialog();
            this.Show();
        }

        private void KhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhoa khoa = new frmKhoa();
            khoa.ShowDialog();
            this.Show();
        }

        private void NganhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNganh nganh = new frmNganh();
            nganh.ShowDialog();
            this.Show();
        }

        private void LopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLop lop= new frmLop();
            lop.ShowDialog();
            this.Show();
        }

        private void frmTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSinhVien sinhvien = new frmSinhVien();
            sinhvien.ShowDialog();
            this.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form1 dangnhap = new Form1();
            dangnhap.ShowDialog();
        }

        private void btnFaculty1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhoa khoa = new frmKhoa();
            khoa.ShowDialog();
            this.Show();
        }
    }
}
