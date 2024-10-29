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
    public class bll_nhacungcap
    {
        dal_nhacungcap dal = new dal_nhacungcap();

        public DataTable getLayDuLieuNhaCungCap()
        {
            DataTable dataTable = new DataTable();
            dataTable = dal.getDataFormNhaCungCap();

            return dataTable;
        }
        public int InsertNhaCungCap(cls_NhaCungCap cls)
        {
            return dal.ThemNhaCungCap(cls);
        }
        public int UpdateNhaCungCap(cls_NhaCungCap cls)
        {
            return dal.SuaNhaCungCap(cls);
        }
        public int DeleteNhaCungCap(string maSP)
        {
            return dal.XoaNhaCungCap(maSP);
        }
    }
}
