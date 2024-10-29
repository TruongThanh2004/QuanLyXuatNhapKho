using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class cls_nhapkho
    {
        private string tenSanPham;
        private float soLuongNhap;
        private string maNhanVien;
        private string soPhieuNhap;
        private string maSanPham;
        private string ngayNhap;

        public string SoPhieuNhap { get => soPhieuNhap; set => soPhieuNhap = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public float SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }

        public cls_nhapkho(string soPhieuNhap, string maSanPham, string tenSanPham, float soLuongNhap, string ngayNhap, string maNhanVien)
        {
            this.soPhieuNhap = soPhieuNhap;
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.soLuongNhap = soLuongNhap;
            this.ngayNhap = ngayNhap;
            this.maNhanVien = maNhanVien;
        }
        public cls_nhapkho()
        {
            
        }
    }
}
