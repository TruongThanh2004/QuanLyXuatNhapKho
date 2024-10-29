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
using DTO;
using System.Data.SqlClient;

namespace GUI
{
    public partial class NhapSanPham : Form
    {
        bll_nhapkho bllNhapKho = new bll_nhapkho();
        bll_sanpham bllSanPham = new bll_sanpham();
        public NhapSanPham()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhapSanPham_FormClosing);
        }

        private void NhapSanPham_Load(object sender, EventArgs e)
        {
            dtgvThongTinNhapKho.DataSource = bllNhapKho.getLayDuLieuNhapKho();
            LoadMaSanPhamComboBox();

            dtgvThongTinNhapKho.Columns[0].Width = 160;
            dtgvThongTinNhapKho.Columns[1].Width = 150;
            dtgvThongTinNhapKho.Columns[2].Width = 180;
            dtgvThongTinNhapKho.Columns[3].Width = 158;
            dtgvThongTinNhapKho.Columns[4].Width = 170;
            dtgvThongTinNhapKho.Columns[5].Width = 149;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string soPhieuNhap = txtSoPhieuNhap.Text;
            string maSP = cbbMaSanPham.Text;
            string tenSP = txtTenSanPham.Text;
            float soLuongNhap = float.Parse(txtSoLuongNhap.Text);
            string ngayNhap = dtpNgayNhap.Text;
            string maNV = cbbMaNhanVien.Text;

            cls_nhapkho nhapKho = new cls_nhapkho(soPhieuNhap, maSP, tenSP, soLuongNhap, ngayNhap, maNV);

            try
            {
                // Truyền số lượng vào phương thức InsertNhaCungCap
                int result = bllNhapKho.InsertNhapKho(nhapKho);

                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công");
                    // Update the DataGridView
                    dtgvThongTinNhapKho.DataSource = bllNhapKho.getLayDuLieuNhapKho();

                    // Cập nhật số lượng sản phẩm ở Form Quản lý sản phẩm
                    bllSanPham.UpdateSoLuongSanPham(maSP, soLuongNhap);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            txtSoPhieuNhap.Focus();
            txtSoPhieuNhap.Text = "";
            txtSoLuongNhap.Text = "";
            cbbMaSanPham.Items[0].ToString();
            cbbMaNhanVien.Items[0].ToString();
            txtTenSanPham.Text = "";
            dtpNgayNhap.Text = "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string soPhieuNhap = txtSoPhieuNhap.Text;
            MessageBox.Show("Xóa thành công");
            bllNhapKho.DeleteNhapKho(soPhieuNhap);

            dtgvThongTinNhapKho.DataSource = bllNhapKho.getLayDuLieuNhapKho();

            txtSoPhieuNhap.Focus();
            txtSoPhieuNhap.Text = "";
            txtSoLuongNhap.Text = "";
            cbbMaNhanVien.Items[0].ToString();
            cbbMaNhanVien.Items[0].ToString();
            txtTenSanPham.Text = "";
            dtpNgayNhap.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string soPhieuNhap = txtSoPhieuNhap.Text;
            string maSP = cbbMaSanPham.Text;
            string tenSP = txtTenSanPham.Text;
            float soLuongNhap = float.Parse(txtSoLuongNhap.Text);
            string ngayNhap = dtpNgayNhap.Text;
            string maNV = cbbMaNhanVien.Text;

            cls_nhapkho nhapKho = new cls_nhapkho(soPhieuNhap, maSP, tenSP, soLuongNhap, ngayNhap, maNV);

            try
            {
                // Truyền số lượng vào phương thức InsertNhaCungCap
                int result = bllNhapKho.UpdateNhapKho(nhapKho);

                if (result >= 0)
                {
                    MessageBox.Show("Sửa thành công");
                    // Update the DataGridView
                    dtgvThongTinNhapKho.DataSource = bllNhapKho.getLayDuLieuNhapKho();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            txtSoPhieuNhap.Focus();
            txtSoPhieuNhap.Text = "";
            txtSoLuongNhap.Text = "";
            cbbMaSanPham.Items[0].ToString();
            cbbMaNhanVien.Items[0].ToString();
            txtTenSanPham.Text = "";
            dtpNgayNhap.Text = "";
        }
        private void LoadMaSanPhamComboBox()
        {
            // Assuming conn is your SqlConnection object
            using (SqlConnection conn = new SqlConnection("Data Source=TruongThen;Initial Catalog=QLHoadon;Integrated Security=True;"))
            {
                conn.Open();

                // Assuming cmd is your SqlCommand object
                using (SqlCommand cmd = new SqlCommand("SelectSanPham", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming the first column is the MaNhaCungCap
                            string maSP = reader.GetString(0);
                            cbbMaSanPham.Items.Add(maSP);
                        }

                        if (cbbMaSanPham.Items.Count > 0)
                        {
                            cbbMaSanPham.Text = cbbMaSanPham.Items[0].ToString();
                        }
                    }
                }
            }
            /* Nhân viên */
            using (SqlConnection conn = new SqlConnection("Data Source=TruongThen;Initial Catalog=QLHoadon;Integrated Security=True;"))
            {
                conn.Open();

                // Assuming cmd is your SqlCommand object
                using (SqlCommand cmd = new SqlCommand("SelectNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming the first column is the MaNhaCungCap
                            string maNV = reader.GetString(0);
                            cbbMaNhanVien.Items.Add(maNV);
                        }

                        if (cbbMaNhanVien.Items.Count > 0)
                        {
                            cbbMaNhanVien.Text = cbbMaNhanVien.Items[0].ToString();
                        }
                    }
                }
            }
        }
        private string LayTenSanPham(string maSP)
        {
            string tenSanPham = string.Empty;

            // Giả sử conn là đối tượng SqlConnection của bạn
            using (SqlConnection conn = new SqlConnection("Data Source=TruongThen;Initial Catalog=QLHoadon;Integrated Security=True;"))
            {
                conn.Open();

                // Giả sử cmd là đối tượng SqlCommand của bạn
                using (SqlCommand cmd = new SqlCommand("SELECT TenSP FROM SANPHAM WHERE MaSP = @MaSP", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Giả sử cột "TenSP" có kiểu dữ liệu là string
                            tenSanPham = reader.GetString(reader.GetOrdinal("TenSP"));
                        }
                    }
                }
            }

            return tenSanPham;
        }

        private void cbbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaSanPham.SelectedItem != null)
            {
                // Lấy mã sản phẩm được chọn
                string selectedMaSP = cbbMaSanPham.SelectedItem.ToString();

                // Gọi phương thức để lấy và hiển thị tên sản phẩm tương ứng
                string productName = LayTenSanPham(selectedMaSP);

                // Hiển thị tên sản phẩm trong txtTenSanPham
                txtTenSanPham.Text = productName;
            }
        }
        private void NhapSanPham_FormClosing(object sender, FormClosingEventArgs e)
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

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.Show();

            this.Hide();
        }

        private void nhậpHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapSanPham nhapSanPham = new NhapSanPham();
            nhapSanPham.Show();

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

        private void dtgvThongTinNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                txtSoPhieuNhap.Text = dtgvThongTinNhapKho.Rows[row].Cells[0].Value.ToString();
                cbbMaSanPham.Text = dtgvThongTinNhapKho.Rows[row].Cells[1].Value.ToString();
                txtTenSanPham.Text = dtgvThongTinNhapKho.Rows[row].Cells[2].Value.ToString();
                txtSoLuongNhap.Text = dtgvThongTinNhapKho.Rows[row].Cells[3].Value.ToString();
                dtpNgayNhap.Text = dtgvThongTinNhapKho.Rows[row].Cells[4].Value.ToString();
                cbbMaNhanVien.Text = dtgvThongTinNhapKho.Rows[row].Cells[5].Value.ToString();
            }
        }
    }
}
