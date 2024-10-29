using QuanLyXuatNhapHangHoa;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "1" && txtMatKhau.Text == "1")
            {
                MessageBox.Show("Đăng nhập thành công");
                TrangChu trangChu = new TrangChu();
                trangChu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }

            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }
    }
}
