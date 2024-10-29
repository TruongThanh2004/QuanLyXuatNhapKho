using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class dal_thongke:connnectDB
    {
        public DataTable getDataThongKe()
        {
            DataTable dtThongKe=new DataTable();
            SqlDataAdapter daThongKe;
            String sql = "sp_ThongKe";
            SqlCommand sqlCMD=new SqlCommand(sql,conn);
            sqlCMD.CommandType = CommandType.StoredProcedure;
            daThongKe=new SqlDataAdapter(sqlCMD);
            daThongKe.Fill(dtThongKe);
            return dtThongKe;
        }
    }
}
