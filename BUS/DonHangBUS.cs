using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using DAO;
namespace BUS
{
    public class DonHangBUS
    {

        public List<DonHang_DTO> GetDonHang(string sql)
        {

            return new DonHangDAO().GetDonHang(sql);

        }
        public int Add(DonHang_DTO dhg)
        {
            //ktra rang buoc tự nhiên
            if (dhg.MaDH == " " || dhg.MaNV == " ")
            {
                return -2; // khong thanh cong se return -2, thành công sẽ return 1 trong DataProvider
            }
            //ktra rang buoc nghiep vu , trong nay có thể ktra đủ 18 tuổi k , có bằng cấp chưa ...
            try
            {
                return (new DonHangDAO().Add(dhg));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
