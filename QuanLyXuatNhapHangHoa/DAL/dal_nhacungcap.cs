using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class dal_nhacungcap:connnectDB
    {
        public DataTable getDataFormNhaCungCap()
        {
            DataTable dtNhaCungCap = new DataTable();
            string sql = "SelectNhaCungCap";
            SqlCommand cmdSQL = new SqlCommand(sql, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daNhaCungCap = new SqlDataAdapter(cmdSQL);
            daNhaCungCap.Fill(dtNhaCungCap);

            return dtNhaCungCap;
        }

        public int ThemNhaCungCap(cls_NhaCungCap clsNCC)
        {
            string sp_insertNhaCungCap = "InsertNhaCungCap";
            SqlCommand cmdSQL = new SqlCommand(sp_insertNhaCungCap, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaNCC", clsNCC.MaNCC);
            cmdSQL.Parameters.AddWithValue("@sTenNCC", clsNCC.TenNCC);
            cmdSQL.Parameters.AddWithValue("@sDiaChiNCC", clsNCC.DiaChiNCC);
            cmdSQL.Parameters.AddWithValue("@sSoDT", clsNCC.SoDienThoaiNCC);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
        public int SuaNhaCungCap(cls_NhaCungCap clsNCC)
        {
            string sp_updateNhaCungCap = "UpdateNhaCungCap";
            SqlCommand cmdSQL = new SqlCommand(sp_updateNhaCungCap, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaNCC", clsNCC.MaNCC);
            cmdSQL.Parameters.AddWithValue("@sTenNCC", clsNCC.TenNCC);
            cmdSQL.Parameters.AddWithValue("@sDiaChiNCC", clsNCC.DiaChiNCC);
            cmdSQL.Parameters.AddWithValue("@sSoDT", clsNCC.SoDienThoaiNCC);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
        public int XoaNhaCungCap(string maNCC)
        {
            string sp_updateNhaCungCap = "DeleteNhaCungCap";
            SqlCommand cmdSQL = new SqlCommand(sp_updateNhaCungCap, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaNCC", maNCC);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
    }
}
