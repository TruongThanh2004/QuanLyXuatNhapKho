using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dal_nhapsanpham:connnectDB
    {
        public DataTable getDataFormNhapKho()
        {
            DataTable dtNhapKho = new DataTable();
            string sql = "SelectNhapKho";
            SqlCommand cmdSQL = new SqlCommand(sql, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daNhapKho = new SqlDataAdapter(cmdSQL);
            daNhapKho.Fill(dtNhapKho);

            return dtNhapKho;
        }

        public int ThemNhapKho(cls_nhapkho clsNSP)
        {
            string sp_insertNhapKho = "InsertNhapKho";
            SqlCommand cmdSQL = new SqlCommand(sp_insertNhapKho, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sSoPhieuNhap", clsNSP.SoPhieuNhap);
            cmdSQL.Parameters.AddWithValue("@sMaSP", clsNSP.MaSanPham);
            cmdSQL.Parameters.AddWithValue("@sSoLuongNhap", clsNSP.SoLuongNhap);
            cmdSQL.Parameters.AddWithValue("@sTenSP", clsNSP.TenSanPham);
            cmdSQL.Parameters.AddWithValue("@sNgayNhap", clsNSP.NgayNhap);
            cmdSQL.Parameters.AddWithValue("@sMaNV", clsNSP.MaNhanVien);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
        public int SuaNhapKho(cls_nhapkho clsNSP)
        {
            string sp_updateNhapKho = "UpdateNhapKho";
            SqlCommand cmdSQL = new SqlCommand(sp_updateNhapKho, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sSoPhieuNhap", clsNSP.SoPhieuNhap);
            cmdSQL.Parameters.AddWithValue("@sMaSP", clsNSP.MaSanPham);
            cmdSQL.Parameters.AddWithValue("@sSoLuongNhap", clsNSP.SoLuongNhap);
            cmdSQL.Parameters.AddWithValue("@sTenSP", clsNSP.TenSanPham);
            cmdSQL.Parameters.AddWithValue("@sNgayNhap", clsNSP.NgayNhap);
            cmdSQL.Parameters.AddWithValue("@sMaNV", clsNSP.MaNhanVien);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
        public int XoaNhapKho(string soPhieuNhap)
        {
            string sp_deleteNhapKho = "DeleteNhapKho";
            SqlCommand cmdSQL = new SqlCommand(sp_deleteNhapKho, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sSoPhieuNhap", soPhieuNhap);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
    }
}
