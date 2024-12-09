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
            frmSinhVien sinhvien = new frmSinhVien();
            sinhvien.ShowDialog();
        }

        private void MonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc monHoc = new frmMonHoc();
            monHoc.ShowDialog();
        }

        private void DiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiem diem = new frmDiem();
            diem.ShowDialog();
        }

        private void KhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa khoa = new frmKhoa();
            khoa.ShowDialog();
        }

        private void NganhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNganh nganh = new frmNganh();
            nganh.ShowDialog();
        }

        private void LopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop lop = new frmLop();
            lop.ShowDialog();
        }
    }
}
