using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class cls_nhanvien
    {
        private string soDienThoaiNV;
        private string maNV;
        private string tenNV;
        private string ngaySinhNV;
        private string gioiTinhNV;
        private string diaChiNV;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgaySinhNV { get => ngaySinhNV; set => ngaySinhNV = value; }
        public string GioiTinhNV { get => gioiTinhNV; set => gioiTinhNV = value; }
        public string DiaChiNV { get => diaChiNV; set => diaChiNV = value; }
        public string SoDienThoaiNV { get => soDienThoaiNV; set => soDienThoaiNV = value; }

        public cls_nhanvien(string maNV, string tenNV, string ngaySinhNV, string gioiTinhNV, string diaChiNV, string soDienThoaiNV)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.NgaySinhNV = ngaySinhNV;
            this.GioiTinhNV = gioiTinhNV;
            this.DiaChiNV = diaChiNV;
            this.SoDienThoaiNV = soDienThoaiNV;
        }
        public cls_nhanvien()
        {
            
        }
    }
}
