using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class cls_sanpham
    {
        private string maSP;
        private string maNCC;
        private string tenSP;
        private float soLuong;
        private float donGia;

        public cls_sanpham(string maSP, string maNCC, string tenSP, float soLuong, float donGia)
        {
            this.MaSP = maSP;
            this.MaNCC = maNCC;
            this.TenSP = tenSP;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

        public cls_sanpham()
        {
            
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public float SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
    }
}
