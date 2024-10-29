using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class connnectDB
    {
        private static string connection = @"Data Source=TruongThen;Initial Catalog=QLHoadon;Integrated Security=True;";
        public SqlConnection conn = new SqlConnection();

        public connnectDB()
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
