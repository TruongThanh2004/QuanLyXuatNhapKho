using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class cls_NhaCungCap
    {
        private string maNCC;
        private string tenNCC;
        private string diaChiNCC;
        private string soDienThoaiNCC;

        public cls_NhaCungCap(string maNCC, string tenNCC, string diaChiNCC, string soDienThoaiNCC)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.DiaChiNCC = diaChiNCC;
            this.SoDienThoaiNCC = soDienThoaiNCC;
        }

        public cls_NhaCungCap()
        {
            
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChiNCC { get => diaChiNCC; set => diaChiNCC = value; }
        public string SoDienThoaiNCC { get => soDienThoaiNCC; set => soDienThoaiNCC = value; }
    }
}
