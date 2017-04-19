using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data.SqlClient;


namespace BUS
{
    public class SanPhamBUS
    {
        public List<SanPhamDTO> Getsanpham(string sql)
        {
            try
            {
                return new SanPhamDAO().Getsanpham(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }


        }
        public int Add(SanPhamDTO sp)
        {
            //tra rang buoc tự nhiên
            if (sp.TenSP == " ")
            {
                return -2; // khong thanh cong se return -2, thành công sẽ return 1 trong DataProvider
            }
            //ktra rang buoc nghiep vu , trong nay có thể ktra đủ 18 tuổi k , có bằng cấp chưa ...
            try
            {
                return (new SanPhamDAO().Add(sp));
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
                return new SanPhamDAO().xoaSP(masanpham);
            }
            catch (Exception ex )
            {
                
                throw ex;
            }


        }
        public int SuaSP(SanPhamDTO sp)
        {
            try
            {
                return new SanPhamDAO().SuaSP(sp);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }


        }
    }
}

