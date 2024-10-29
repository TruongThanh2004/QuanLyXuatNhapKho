using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhaCungCap : Form
    {
        bll_nhacungcap bllNhaCungCap = new bll_nhacungcap();
        public NhaCungCap()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhaCungCap_FormClosing);
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            dtgvThongTinNhaCungCap.DataSource = bllNhaCungCap.getLayDuLieuNhaCungCap();

            dtgvThongTinNhaCungCap.Columns[0].Width = 150;
            dtgvThongTinNhaCungCap.Columns[1].Width = 200;
            dtgvThongTinNhaCungCap.Columns[2].Width = 466;
            dtgvThongTinNhaCungCap.Columns[3].Width = 150;
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNhaCungCap.Text;
            string diaChiNCC = txtDiaChiNCC.Text;
            string soDTNCC = txtDienThoaiNCC.Text;

            cls_NhaCungCap nhaCungCap = new cls_NhaCungCap(maNCC, tenNCC, diaChiNCC, soDTNCC);

            try
            {
                int result = bllNhaCungCap.InsertNhaCungCap(nhaCungCap);

                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công");
                    dtgvThongTinNhaCungCap.DataSource = bllNhaCungCap.getLayDuLieuNhaCungCap();
                }
            }
            catch (Exception)
            {

                throw;
            }

            txtMaNCC.Text = "";
            txtTenNhaCungCap.Text = "";
            txtDiaChiNCC.Text = "";
            txtDienThoaiNCC.Text = "";
            
            txtMaNCC.Focus();
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            MessageBox.Show("Xóa thành công");
            bllNhaCungCap.DeleteNhaCungCap(maNCC);
            dtgvThongTinNhaCungCap.DataSource = bllNhaCungCap.getLayDuLieuNhaCungCap();

            txtMaNCC.Text = "";
            txtTenNhaCungCap.Text = "";
            txtDiaChiNCC.Text = "";
            txtDienThoaiNCC.Text = "";

            txtMaNCC.Focus();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNhaCungCap.Text;
            string diaChiNCC = txtDiaChiNCC.Text;
            string soDTNCC = txtDienThoaiNCC.Text;

            cls_NhaCungCap nhaCungCap = new cls_NhaCungCap(maNCC, tenNCC, diaChiNCC, soDTNCC);

            try
            {
                int result = bllNhaCungCap.UpdateNhaCungCap(nhaCungCap);

                if (result >= 0)
                {
                    MessageBox.Show("Sửa thành công");
                    dtgvThongTinNhaCungCap.DataSource = bllNhaCungCap.getLayDuLieuNhaCungCap();
                }
            }
            catch (Exception)
            {

                throw;
            }

            txtMaNCC.Text = "";
            txtTenNhaCungCap.Text = "";
            txtDiaChiNCC.Text = "";
            txtDienThoaiNCC.Text = "";

            txtMaNCC.Focus();
        }

        private void NhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Nếu form chủ đóng bởi người dùng
                DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Ngăn chặn đóng form
                }
                else
                {
                    Application.Exit(); // Tắt toàn bộ ứng dụng khi người dùng chấp nhận thoát
                }
            }
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu trangChu = new TrangChu();
            trangChu.Show();

            this.Hide();
        }

        private void nhậpHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapSanPham nhapSanPham = new NhapSanPham();
            nhapSanPham.Show();

            this.Hide();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.Show();

            this.Hide();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Show();

            this.Hide();
        }
        private void xuấtHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuatKho xuatKho = new XuatKho();
            xuatKho.Show();

            this.Hide();
        }

        private void dtgvThongTinNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                txtMaNCC.Text = dtgvThongTinNhaCungCap.Rows[row].Cells[0].Value.ToString();
                txtTenNhaCungCap.Text = dtgvThongTinNhaCungCap.Rows[row].Cells[1].Value.ToString();
                txtDiaChiNCC.Text = dtgvThongTinNhaCungCap.Rows[row].Cells[2].Value.ToString();
                txtDienThoaiNCC.Text = dtgvThongTinNhaCungCap.Rows[row].Cells[3].Value.ToString();
            }
        }
    }
}
