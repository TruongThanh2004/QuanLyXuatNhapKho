using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Data.SqlClient;
using QuanLyXuatNhapHangHoa;

namespace GUI
{
    public partial class TrangChu : Form
    {
        bll_sanpham bllSanPham = new bll_sanpham();
        public TrangChu()
        {
            InitializeComponent();
            txtSoLuong.Enabled = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChu_FormClosing);
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void TrangChu_Load(object sender, EventArgs e)
        {
            dtgvThongTinSanPham.DataSource = bllSanPham.getLayDuLieuSanPham();
            dtgvThongTinSanPham.Columns[0].Width = 180;
            dtgvThongTinSanPham.Columns[1].Width = 200;
            dtgvThongTinSanPham.Columns[2].Width = 200;
            dtgvThongTinSanPham.Columns[3].Width = 200;
            dtgvThongTinSanPham.Columns[4].Width = 187;

            LoadNhaCungCapComboBox();
        }

        private void LoadNhaCungCapComboBox()
        {
            // Assuming conn is your SqlConnection object
            using (SqlConnection conn = new SqlConnection("Data Source=TruongThen;Initial Catalog=QLHoadon;Integrated Security=True;"))
            {
                conn.Open();

                // Assuming cmd is your SqlCommand object
                using (SqlCommand cmd = new SqlCommand("SelectNhaCungCap", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming the first column is the MaNhaCungCap
                            string maNCC = reader.GetString(0);
                            cbbMaNCC.Items.Add(maNCC);
                        }

                        if (cbbMaNCC.Items.Count > 0)
                        {
                            cbbMaNCC.Text = cbbMaNCC.Items[0].ToString();
                        }
                    }
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string maNCC = cbbMaNCC.Text;
            string tenSP = txtTenSP.Text;
            float soLuong = 0;

            if (!string.IsNullOrEmpty(txtSoLuong.Text))
            {
                float.TryParse(txtSoLuong.Text, out soLuong);
            }

            float donGia = float.Parse(txtDonGia.Text);

            cls_sanpham sanPham = new cls_sanpham(maSP, maNCC, tenSP, soLuong, donGia);

            try
            {
                int result = bllSanPham.InsertSanPham(sanPham);

                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công");
                    // Update the DataGridView
                    dtgvThongTinSanPham.DataSource = bllSanPham.getLayDuLieuSanPham();
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

            txtMaSP.Text = "";
            if (cbbMaNCC.Items.Count > 0)
            {
                cbbMaNCC.Text = cbbMaNCC.Items[0].ToString();
            }
            txtTenSP.Text = "";
            txtDonGia.Text = "";
        }

        private void dtgvThongTinSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;

            if (Row >= 0)
            {
                txtMaSP.Text = dtgvThongTinSanPham.Rows[Row].Cells[0].Value.ToString();
                cbbMaNCC.Text = dtgvThongTinSanPham.Rows[Row].Cells[1].Value.ToString();
                txtTenSP.Text = dtgvThongTinSanPham.Rows[Row].Cells[2].Value.ToString();
                txtSoLuong.Text = dtgvThongTinSanPham.Rows[Row].Cells[3].Value.ToString();
                txtDonGia.Text = dtgvThongTinSanPham.Rows[Row].Cells[4].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            MessageBox.Show("Xóa thành công");
            bllSanPham.DeleteSanPham(maSP);
            dtgvThongTinSanPham.DataSource = bllSanPham.getLayDuLieuSanPham();

            txtMaSP.Text = "";
            if (cbbMaNCC.Items.Count > 0)
            {
                cbbMaNCC.Text = cbbMaNCC.Items[0].ToString();
            }
            txtTenSP.Text = "";
            txtDonGia.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string maNCC = cbbMaNCC.Text;
            string tenSP = txtTenSP.Text;
            float soLuong = 0;

            if (!string.IsNullOrEmpty(txtSoLuong.Text))
            {
                float.TryParse(txtSoLuong.Text, out soLuong);
            }

            float donGia = float.Parse(txtDonGia.Text);

            cls_sanpham sanPham = new cls_sanpham(maSP, maNCC, tenSP, soLuong, donGia);

            try
            {
                int result = bllSanPham.UpdateSanPham(sanPham);

                if (result >= 0)
                {
                    MessageBox.Show("Sửa thành công");
                    // Update the DataGridView
                    dtgvThongTinSanPham.DataSource = bllSanPham.getLayDuLieuSanPham();
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

            txtMaSP.Text = "";
            if (cbbMaNCC.Items.Count > 0)
            {
                cbbMaNCC.Text = cbbMaNCC.Items[0].ToString();
            }
            txtTenSP.Text = "";
            txtDonGia.Text = "";
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.Show();

            this.Hide();
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

        private void dtgvThongTinSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
