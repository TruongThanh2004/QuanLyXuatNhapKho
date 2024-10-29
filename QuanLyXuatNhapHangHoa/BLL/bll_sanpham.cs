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
    public class bll_sanpham
    {
        dal_sanpham  dal = new dal_sanpham();
        public DataTable getLayDuLieuSanPham()
        {
            DataTable dataTable = new DataTable();
            dataTable = dal.getDataFromSanPham();

            return dataTable;
        }
        public int InsertSanPham(cls_sanpham cls)
        {
            return dal.ThemSanPham(cls);
        }

        public int UpdateSoLuongSanPham(string maSP, float soLuong)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=TruongThen;Initial Catalog=QLHoadon;Integrated Security=True;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_updateSoLuongSanPham", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@SoLuongMoi", soLuong);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public int UpdateTruSoLuongSanPham(string maSP, float soLuong)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=TruongThen;Initial Catalog=QLHoadon;Integrated Security=True;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_updateTruSoLuongSanPham", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@SoLuongMoi", soLuong);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public int UpdateSanPham(cls_sanpham cls)
        {
            return dal.SuaSanPham(cls);
        }
        public int DeleteSanPham(string maSP)
        {
            return dal.XoaSanPham(maSP);
        }
    }
}
