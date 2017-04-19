using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class DonHangDAO
    {
        private DataProvider dp;
        public DonHangDAO()
        {
            dp = new DataProvider();
        }
        public List<DonHang_DTO> GetDonHang(string sql)
        {
            dp.connect();

            List<DonHang_DTO> list = new List<DonHang_DTO>();
            {
                
                string mahd,manv, makh, ndat, ngiao;
                try
                {
                    SqlDataReader dr = dp.ExecuteReader(sql);
                    while (dr.Read())
                    {
                        mahd = dr.GetString(0);
                        makh = dr.GetString(1);
                        manv = dr.GetString(2);
                        ndat = dr.GetString(3);
                        ngiao = dr.GetString(4);
                        DonHang_DTO dh = new DonHang_DTO(mahd, makh, manv, ndat, ngiao);
                        list.Add(dh);
                    }
                    dr.Close();
                    return list;
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
                finally { dp.disconnect(); }




            }


        }
        public int Add(DonHang_DTO dhg)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@madh",dhg.MaDH));
           
            paras.Add(new SqlParameter("@makh", dhg.MaKH));
            paras.Add(new SqlParameter("@manv", dhg.MaNV));

            paras.Add(new SqlParameter("@ndat", dhg.NgayDatHang));
            paras.Add(new SqlParameter("@ngiao", dhg.NgayGiaoHang));
           


            try
            {
                return (dp.ExcuteNonQuery("ThemDH", System.Data.CommandType.StoredProcedure, paras));
                // " ten thu tuc " , loại , danh sach 
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}