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
    public class bll_xuatkho
    {
        dal_xuatkho dal = new dal_xuatkho();

        public DataTable getLayDuLieuXuatKho()
        {
            DataTable dataTable = new DataTable();
            dataTable = dal.getDataFormXuatKho();

            return dataTable;
        }

        public int InsertNhapKho(cls_xuatkho cls)
        {
            return dal.ThemXuatKho(cls);
        }
        public int UpdateNhapKho(cls_xuatkho cls)
        {
            return dal.SuaXuatKho(cls);
        }

        public int DeleteNhapKho(string soPhieuXuat)
        {
            return dal.XoaXuatKho(soPhieuXuat);
        }
    }
}
