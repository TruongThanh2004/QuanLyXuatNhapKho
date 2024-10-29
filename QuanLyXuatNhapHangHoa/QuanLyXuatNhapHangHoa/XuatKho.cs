using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class XuatKho : Form
    {
        bll_xuatkho bllXuatKho = new bll_xuatkho();
        bll_sanpham bllSanpham = new bll_sanpham(); 
        public XuatKho()
        {
            InitializeComponent();
            txtSoLuongSanPham.Enabled = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XuatKho_FormClosing);
        }

        private void XuatKho_FormClosing(object sender, FormClosingEventArgs e)
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
        private void XuatKho_Load(object sender, EventArgs e)
        {
            dtgvThongTinXuatKho.DataSource = bllXuatKho.getLayDuLieuXuatKho();

            dtgvThongTinXuatKho.Columns[0].Width = 140;
            dtgvThongTinXuatKho.Columns[1].Width = 157;
            dtgvThongTinXuatKho.Columns[2].Width = 150;
            dtgvThongTinXuatKho.Columns[3].Width = 130;
            dtgvThongTinXuatKho.Columns[4].Width = 120;
            dtgvThongTinXuatKho.Columns[5].Width = 150;
            dtgvThongTinXuatKho.Columns[6].Width = 120;

            LoadMaSanPhamComboBox();
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

        private float LaySoLuongSanPham(string maSP)
        {
            float soLuong = 0;

            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection("Data Source=TruongThen;Initial Catalog=QLHoadon;Integrated Security=True;"))
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo và thực hiện câu truy vấn SQL
                    using (SqlCommand cmd = new SqlCommand("SELECT SoLuong FROM SANPHAM WHERE MaSP = @MaSP", conn))
                    {
                        // Thêm tham số vào câu truy vấn
                        cmd.Parameters.AddWithValue("@MaSP", maSP);

                        // Thực hiện đọc dữ liệu từ cơ sở dữ liệu
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra xem có dữ liệu để đọc không
                            if (reader.Read())
                            {
                                // Kiểm tra giá trị đọc được từ cơ sở dữ liệu
                                Console.WriteLine($"Giá trị SoLuong từ CSDL: {reader["SoLuong"]}");

                                // Sử dụng TryParse để đảm bảo giá trị có thể chuyển đổi thành số float
                                if (float.TryParse(reader["SoLuong"].ToString(), out soLuong))
                                {
                                    // Giá trị đã được chuyển đổi thành công
                                    Console.WriteLine($"Giá trị SoLuong sau khi chuyển đổi: {soLuong}");
                                }
                                else
                                {
                                    // Không thể chuyển đổi giá trị thành số float
                                    Console.WriteLine("Không thể chuyển đổi giá trị SoLuong thành số float.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log hoặc in ra thông báo lỗi để xác định vấn đề
                Console.WriteLine($"Lỗi khi lấy số lượng sản phẩm từ CSDL: {ex.Message}");
            }

            // Trả về giá trị số lượng
            return soLuong;
        }


        private void cbbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaSanPham.SelectedItem != null)
            {
                // Lấy mã sản phẩm được chọn
                string selectedMaSP = cbbMaSanPham.SelectedItem.ToString();
                // Gọi phương thức để lấy và hiển thị tên sản phẩm tương ứng
                string productName = LayTenSanPham(selectedMaSP);
                float soLuong = LaySoLuongSanPham(selectedMaSP);
                // Hiển thị tên sản phẩm trong txtTenSanPham
                txtTenSanPham.Text = productName;
                txtSoLuongSanPham.Text = soLuong.ToString();  
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string soPhieuXuat = txtSoPhieuXuat.Text;
            string maSP = cbbMaSanPham.Text;
            string tenSP = txtTenSanPham.Text;
            
            float soLuongXuat = float.Parse(txtSoLuongXuat.Text);
            float soLuongDangCo = float.Parse(txtSoLuongSanPham.Text)-soLuongXuat;
            string ngayNhap = dtpNgayXuat.Text;
            string maNV = cbbMaNhanVien.Text;

            cls_xuatkho xuatKho = new cls_xuatkho(soPhieuXuat, maSP, tenSP, soLuongDangCo, ngayNhap, soLuongXuat, maNV);

            try
            {
                // Truyền số lượng vào phương thức InsertNhaCungCap
                int result = bllXuatKho.InsertNhapKho(xuatKho);

                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công");
                    // Update the DataGridView
                    dtgvThongTinXuatKho.DataSource = bllXuatKho.getLayDuLieuXuatKho();

                    // Cập nhật số lượng sản phẩm ở Form Quản lý sản phẩm
                    bllSanpham.UpdateTruSoLuongSanPham(maSP, soLuongXuat);
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

            txtSoPhieuXuat.Focus();
            txtSoPhieuXuat.Text = "";
            txtSoLuongXuat.Text = "";
            txtSoLuongSanPham.Text = "";
            cbbMaSanPham.Items[0].ToString();
            cbbMaNhanVien.Items[0].ToString();
            txtTenSanPham.Text = "";
            dtpNgayXuat.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string soPhieuXuat = txtSoPhieuXuat.Text;
            MessageBox.Show("Xóa thành công");

            bllXuatKho.DeleteNhapKho(soPhieuXuat);

            dtgvThongTinXuatKho.DataSource = bllXuatKho.getLayDuLieuXuatKho();

            txtSoPhieuXuat.Focus();
            txtSoPhieuXuat.Text = "";
            txtSoLuongXuat.Text = "";
            txtSoLuongSanPham.Text = "";
            cbbMaSanPham.Items[0].ToString();
            cbbMaNhanVien.Items[0].ToString();
            txtTenSanPham.Text = "";
            dtpNgayXuat.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string soPhieuXuat = txtSoPhieuXuat.Text;
            string maSP = cbbMaSanPham.Text;
            string tenSP = txtTenSanPham.Text;
            float soLuongDangCo = float.Parse(txtSoLuongSanPham.Text);
            float soLuongXuat = float.Parse(txtSoLuongXuat.Text);
            string ngayNhap = dtpNgayXuat.Text;
            string maNV = cbbMaNhanVien.Text;

            cls_xuatkho xuatKho = new cls_xuatkho(soPhieuXuat, maSP, tenSP, soLuongDangCo, ngayNhap, soLuongXuat, maNV);

            try
            {
                // Truyền số lượng vào phương thức InsertNhaCungCap
                int result = bllXuatKho.UpdateNhapKho(xuatKho);

                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công");
                    // Update the DataGridView
                    dtgvThongTinXuatKho.DataSource = bllXuatKho.getLayDuLieuXuatKho();
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

            txtSoPhieuXuat.Focus();
            txtSoPhieuXuat.Text = "";
            txtSoLuongXuat.Text = "";
            txtSoLuongSanPham.Text = "";
            cbbMaSanPham.Items[0].ToString();
            cbbMaNhanVien.Items[0].ToString();
            txtTenSanPham.Text = "";
            dtpNgayXuat.Text = "";
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

        private void xuấtHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuatKho xuatKho = new XuatKho();
            xuatKho.Show();

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
            NhanVien nhanVien  = new NhanVien();
            nhanVien.Show();

            this.Hide();
        }
    }
}
