using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bll_nhapkho
    {
        dal_nhapsanpham dal = new dal_nhapsanpham();

        public DataTable getLayDuLieuNhapKho()
        {
            DataTable dataTable = new DataTable();
            dataTable = dal.getDataFormNhapKho();

            return dataTable;
        }

        public int InsertNhapKho(cls_nhapkho cls)
        {
            return dal.ThemNhapKho(cls);
        }
        public int UpdateNhapKho(cls_nhapkho cls)
        {
            return dal.SuaNhapKho(cls);
        }

        public int DeleteNhapKho(string soPhieuNhap)
        {
            return dal.XoaNhapKho(soPhieuNhap);
        }
    }
}
