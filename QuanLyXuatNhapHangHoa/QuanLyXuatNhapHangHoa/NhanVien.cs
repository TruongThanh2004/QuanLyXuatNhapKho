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
    public partial class NhanVien : Form
    {
        bll_nhanvien bllNhanVien = new bll_nhanvien();
        public NhanVien()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhanVien_FormClosing);
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dtgvThongTinNhanVien.DataSource = bllNhanVien.getLayDuLieuNhanVien();
            cbbGioiTinhNV.Text = cbbGioiTinhNV.Items[0].ToString();

            dtgvThongTinNhanVien.Columns[0].Width = 140;
            dtgvThongTinNhanVien.Columns[1].Width = 160;
            dtgvThongTinNhanVien.Columns[2].Width = 100;
            dtgvThongTinNhanVien.Columns[3].Width = 100;
            dtgvThongTinNhanVien.Columns[4].Width = 317;
            dtgvThongTinNhanVien.Columns[5].Width = 150;
        }

        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoTenNV = txtHoTenNV.Text;
            string ngaySinh = dtpNgaySinhNV.Text;
            string gioiTinh = cbbGioiTinhNV.Text;
            string diaChi = txtDiaChiNV.Text;
            string soDienThoai = txtSoDienThoaiNV.Text;

            cls_nhanvien nhanVien = new cls_nhanvien(maNV, hoTenNV, ngaySinh, gioiTinh, diaChi, soDienThoai);

            try
            {
                int result = bllNhanVien.InsertNhanVien(nhanVien);

                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công");
                    dtgvThongTinNhanVien.DataSource = bllNhanVien.getLayDuLieuNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }    
            }
            catch (Exception)
            {

                throw;
            }

            txtMaNV.Focus();

            txtMaNV.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtDiaChiNV.Text = string.Empty;
            txtSoDienThoaiNV.Text = string.Empty;
            cbbGioiTinhNV.Items[0].ToString();
            dtpNgaySinhNV.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            MessageBox.Show("Xóa thành công");
            bllNhanVien.DeleteNhanVien(maNV);

            dtgvThongTinNhanVien.DataSource = bllNhanVien.getLayDuLieuNhanVien();

            txtMaNV.Focus();

            txtMaNV.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtDiaChiNV.Text = string.Empty;
            txtSoDienThoaiNV.Text = string.Empty;
            cbbGioiTinhNV.Items[0].ToString();
            dtpNgaySinhNV.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoTenNV = txtHoTenNV.Text;
            string ngaySinh = dtpNgaySinhNV.Text;
            string gioiTinh = cbbGioiTinhNV.Text;
            string diaChi = txtDiaChiNV.Text;
            string soDienThoai = txtSoDienThoaiNV.Text;

            cls_nhanvien nhanVien = new cls_nhanvien(maNV, hoTenNV, ngaySinh, gioiTinh, diaChi, soDienThoai);

            try
            {
                int result = bllNhanVien.UpdateNhanVien(nhanVien);

                if (result >= 0)
                {
                    MessageBox.Show("Sửa thành công");
                    dtgvThongTinNhanVien.DataSource = bllNhanVien.getLayDuLieuNhanVien();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            catch (Exception)
            {

                throw;
            }

            txtMaNV.Focus();

            txtMaNV.Text = string.Empty;
            txtHoTenNV.Text = string.Empty;
            txtDiaChiNV.Text = string.Empty;
            txtSoDienThoaiNV.Text = string.Empty;
            cbbGioiTinhNV.Items[0].ToString();
            dtpNgaySinhNV.Text = "";
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

        private void dtgvThongTinNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                txtMaNV.Text = dtgvThongTinNhanVien.Rows[row].Cells[0].ToString();
                txtHoTenNV.Text = dtgvThongTinNhanVien.Rows[row].Cells[1].ToString();
                dtpNgaySinhNV.Text = dtgvThongTinNhanVien.Rows[row].Cells[2].ToString();
                cbbGioiTinhNV.Text = dtgvThongTinNhanVien.Rows[row].Cells[3].ToString();
                txtDiaChiNV.Text = dtgvThongTinNhanVien.Rows[row].Cells[4].ToString();
                txtSoDienThoaiNV.Text = dtgvThongTinNhanVien.Rows[row].Cells[5].ToString();
            }
        }
    }
}
