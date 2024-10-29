using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dal_nhanvien:connnectDB
    {
        public DataTable getDataFormNhanVien()
        {
            DataTable dtNhanVien = new DataTable();
            string sql = "SelectNhanVien";
            SqlCommand cmdSQL = new SqlCommand(sql, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daNhanVien = new SqlDataAdapter(cmdSQL);
            daNhanVien.Fill(dtNhanVien);

            return dtNhanVien;
        }

        public int ThemNhanVien(cls_nhanvien clsNV)
        {
            string sp_insertNhapKho = "InsertNhapKho";
            SqlCommand cmdSQL = new SqlCommand(sp_insertNhapKho, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaNV", clsNV.MaNV);
            cmdSQL.Parameters.AddWithValue("@sHoTenNV", clsNV.TenNV);
            cmdSQL.Parameters.AddWithValue("@sNgaySinh", clsNV.NgaySinhNV);
            cmdSQL.Parameters.AddWithValue("@sGioiTinh", clsNV.GioiTinhNV);
            cmdSQL.Parameters.AddWithValue("@sDiaChiNV", clsNV.DiaChiNV);
            cmdSQL.Parameters.AddWithValue("@sSoDTNV", clsNV.SoDienThoaiNV);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
        public int SuaNhanVien(cls_nhanvien clsNV)
        {
            string sp_updateNhanVien = "UpdateNhanVien";
            SqlCommand cmdSQL = new SqlCommand(sp_updateNhanVien, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaNV", clsNV.MaNV);
            cmdSQL.Parameters.AddWithValue("@sHoTenNV", clsNV.TenNV);
            cmdSQL.Parameters.AddWithValue("@sNgaySinh", clsNV.NgaySinhNV);
            cmdSQL.Parameters.AddWithValue("@sGioiTinh", clsNV.GioiTinhNV);
            cmdSQL.Parameters.AddWithValue("@sDiaChiNV", clsNV.DiaChiNV);
            cmdSQL.Parameters.AddWithValue("@sSoDTNV", clsNV.SoDienThoaiNV);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
        public int XoaNhanVien(string maNV)
        {
            string sp_deleteNhanVien = "DeleteNhapKho";
            SqlCommand cmdSQL = new SqlCommand(sp_deleteNhanVien, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sSoPhieuNhap", maNV);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
    }
}
