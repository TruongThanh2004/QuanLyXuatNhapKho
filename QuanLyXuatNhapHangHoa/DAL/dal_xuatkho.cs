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
    public class dal_xuatkho:connnectDB
    {
        public DataTable getDataFormXuatKho()
        {
            DataTable dtXuatKho = new DataTable();
            string sql = "SelectXuatKho";
            SqlCommand cmdSQL = new SqlCommand(sql, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daXuatKho = new SqlDataAdapter(cmdSQL);
            daXuatKho.Fill(dtXuatKho);

            return dtXuatKho;
        }

        public int ThemXuatKho(cls_xuatkho clsXK)
        {
            string sp_insertNhapKho = "InsertXuatKho";
            SqlCommand cmdSQL = new SqlCommand(sp_insertNhapKho, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sSoPhieuXuat", clsXK.SoPhieuXuat);
            cmdSQL.Parameters.AddWithValue("@sMaSP", clsXK.MaSanPham);
            cmdSQL.Parameters.AddWithValue("@sTenSP", clsXK.TenSanPham);
            cmdSQL.Parameters.AddWithValue("@sSoLuongSP", clsXK.SoLuongDangCo);
            cmdSQL.Parameters.AddWithValue("@sSoLuongXuat", clsXK.SoLuongXuat);
            cmdSQL.Parameters.AddWithValue("@sNgayXuat", clsXK.NgayXuat);
            cmdSQL.Parameters.AddWithValue("@sMaNV", clsXK.MaNhanVien);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
        public int SuaXuatKho(cls_xuatkho clsXK)
        {
            string sp_insertNhapKho = "UpdateXuatKho";
            SqlCommand cmdSQL = new SqlCommand(sp_insertNhapKho, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sSoPhieuXuat", clsXK.SoPhieuXuat);
            cmdSQL.Parameters.AddWithValue("@sMaSP", clsXK.MaSanPham);
            cmdSQL.Parameters.AddWithValue("@sTenSP", clsXK.TenSanPham);
            cmdSQL.Parameters.AddWithValue("@sSoLuongSP", clsXK.SoLuongDangCo);
            cmdSQL.Parameters.AddWithValue("@sSoLuongXuat", clsXK.SoLuongXuat);
            cmdSQL.Parameters.AddWithValue("@sNgayXuat", clsXK.NgayXuat);
            cmdSQL.Parameters.AddWithValue("@sMaNV", clsXK.MaNhanVien);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
        public int XoaXuatKho(string soPhieuXuat)
        {
            string sp_deleteXuatKho = "DeleteXuatKho";
            SqlCommand cmdSQL = new SqlCommand(sp_deleteXuatKho, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sSoPhieuXuat", soPhieuXuat);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
    }
}
