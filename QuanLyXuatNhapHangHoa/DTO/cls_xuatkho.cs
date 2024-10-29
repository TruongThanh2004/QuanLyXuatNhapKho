using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class cls_xuatkho
    {
        private string soPhieuXuat;
        private string maSanPham;
        private string tenSanPham;
        private float soLuongDangCo;
        private string ngayXuat;
        private float soLuongXuat;
        private string maNhanVien;

        public string SoPhieuXuat { get => soPhieuXuat; set => soPhieuXuat = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public float SoLuongDangCo { get => soLuongDangCo; set => soLuongDangCo = value; }
        public string NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        public float SoLuongXuat { get => soLuongXuat; set => soLuongXuat = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }

        public cls_xuatkho(string soPhieuXuat, string maSanPham, string tenSanPham, float soLuongDangCo, string ngayXuat, float soLuongXuat, string maNhanVien)
        {
            this.SoPhieuXuat = soPhieuXuat;
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.SoLuongDangCo = soLuongDangCo;
            this.NgayXuat = ngayXuat;
            this.SoLuongXuat = soLuongXuat;
            this.MaNhanVien = maNhanVien;
        }
    }
}
