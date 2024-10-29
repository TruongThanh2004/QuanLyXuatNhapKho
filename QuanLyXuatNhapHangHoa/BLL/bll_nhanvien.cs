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
    public class bll_nhanvien
    {
        dal_nhanvien dal = new dal_nhanvien();
        public DataTable getLayDuLieuNhanVien()
        {
            DataTable dataTable = new DataTable();
            dataTable = dal.getDataFormNhanVien();

            return dataTable;
        }

        public int InsertNhanVien(cls_nhanvien cls)
        {
            return dal.ThemNhanVien(cls);
        }
        public int UpdateNhanVien(cls_nhanvien cls)
        {
            return dal.SuaNhanVien(cls);
        }
        public int DeleteNhanVien(string maNV)
        {
            return dal.XoaNhanVien(maNV);
        }
    }
}
