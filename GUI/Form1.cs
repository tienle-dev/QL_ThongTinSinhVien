using BLL;
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
    public partial class Form1 : Form
    {
        private readonly BusinessLogic _logic;
        public Form1()
        {
            InitializeComponent();
            _logic = new BusinessLogic();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            frmTrangChu trangchu = new frmTrangChu();
            trangchu.ShowDialog();
            this.Show();
            */
            var username = txtID.Text;
            var password = txtMatkhau.Text;

            if (_logic.Login(username, password))
            {
                var homeForm = new frmTrangChu();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
