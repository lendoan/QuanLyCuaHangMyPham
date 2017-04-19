using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class SanPhamDAO
    {
        private DataProvider dp;
        public SanPhamDAO()
        {
            dp = new DataProvider();

        }
        public List<SanPhamDTO> Getsanpham(string sql)
        {
            dp.connect();
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            {

                string masp, tensp, mota, tinhtrang, manguoncungcap, maloaisp;
                double dongia;
                try
                {
                    SqlDataReader dr = dp.ExecuteReader(sql);
                    while (dr.Read())
                    {
                        masp = dr.GetString(0);
                        tensp = dr.GetString(1);
                        mota = dr.GetString(2);
                        dongia = dr.GetDouble(3);
                        tinhtrang = dr.GetString(4);
                        manguoncungcap = dr.GetString(5);
                        maloaisp = dr.GetString(6);

                        SanPhamDTO sp = new SanPhamDTO(masp, tensp, mota, dongia, tinhtrang, manguoncungcap, maloaisp);
                        list.Add(sp);


                    }
                    dr.Close();
                    return list;
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
                finally
                {
                    dp.disconnect();
                }


            }
        }
        public int Add(SanPhamDTO sp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@masp", sp.MaSP));
            paras.Add(new SqlParameter("@tensp", sp.TenSP));
            paras.Add(new SqlParameter("@mota", sp.MoTa));
            paras.Add(new SqlParameter("@dongia", sp.DonGia));
            paras.Add(new SqlParameter("@tinhtrang", sp.TinhTrang));
            paras.Add(new SqlParameter("@manguoncungcap", sp.MaNguonCungCap));
            paras.Add(new SqlParameter("@maloaisp", sp.MaLoaiSP));



            try
            {
                return (dp.ExcuteNonQuery("[addsanpham]", System.Data.CommandType.StoredProcedure, paras));
                // " ten thu tuc " , loại , danh sach 
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int xoaSP(string masanpham)
        {
           
            try
            {
                
                string sql = @"delete from SanPham where MaSP='" +masanpham+ "'";
                return dp.ExcuteNonQuery(sql, CommandType.Text, null);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int SuaSP(SanPhamDTO sp)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@Masp", sp.MaSP));
            list.Add(new SqlParameter("@Tensp",sp.TenSP));
            list.Add(new SqlParameter("@Mota", sp.MoTa));
            list.Add(new SqlParameter("@Dongia", sp.DonGia));
            list.Add(new SqlParameter("@Tinhtrang", sp.TinhTrang));
            list.Add(new SqlParameter("@Manguoncungcap", sp.MaNguonCungCap));
            list.Add(new SqlParameter("@Maloaisp", sp.MaLoaiSP));

            try
            {
                return (dp.ExcuteNonQuery("Suasanpham", CommandType.StoredProcedure, list));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
