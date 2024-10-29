using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class bll_ThongKe
    {
        dal_thongke dalThongKe=new dal_thongke();
        public DataTable getDuLieuThongKe()
        {
            DataTable dataTable = new DataTable();
            dataTable = dalThongKe.getDataThongKe();
            return dataTable;   
        }
    }
}
