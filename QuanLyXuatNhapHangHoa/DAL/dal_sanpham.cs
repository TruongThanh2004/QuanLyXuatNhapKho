using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class dal_sanpham:connnectDB
    {
        public DataTable getDataFromSanPham()
        {
            DataTable dtSanPham = new DataTable();
            string sql = "SelectSanPham";
            SqlCommand cmdSQL = new SqlCommand(sql, conn);
            SqlDataAdapter daSanPham = new SqlDataAdapter(cmdSQL);
            daSanPham.Fill(dtSanPham);

            return dtSanPham;
        }
        public int ThemSanPham(cls_sanpham clsSanPham)
        {
            string sp_insertSanPham = "InsertSanPham";
            SqlCommand cmdSQL = new SqlCommand(sp_insertSanPham, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaSP", clsSanPham.MaSP);
            cmdSQL.Parameters.AddWithValue("@sMaNhaCungCap", clsSanPham.MaNCC);
            cmdSQL.Parameters.AddWithValue("@sTenSP", clsSanPham.TenSP);
            cmdSQL.Parameters.AddWithValue("@sSoLuong", clsSanPham.SoLuong);
            cmdSQL.Parameters.AddWithValue("@sDonGia", clsSanPham.DonGia);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
        public int SuaSanPham(cls_sanpham clsSanPham)
        {
            string sp_updateSanPham = "UpdateSanPham";
            SqlCommand cmdSQL = new SqlCommand(sp_updateSanPham, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaNhaCungCap", clsSanPham.MaNCC);
            cmdSQL.Parameters.AddWithValue("@sTenSP", clsSanPham.TenSP);
            cmdSQL.Parameters.AddWithValue("@sSoLuong", clsSanPham.SoLuong);
            cmdSQL.Parameters.AddWithValue("@sDonGia", clsSanPham.DonGia);
            cmdSQL.Parameters.AddWithValue("@sMaSP", clsSanPham.MaSP);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
        public int XoaSanPham(string maSP)
        {
            string sp_updateSanPham = "DeleteSanPham";
            SqlCommand cmdSQL = new SqlCommand(sp_updateSanPham, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMaSP", maSP);

            int result = cmdSQL.ExecuteNonQuery();

            return result;
        }
    }
}
