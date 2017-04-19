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
    public class CustomerBUS
    {
        public List<CustomerDTO> GetCustomer(string sql)
        {

            return new CustomerDAO().GetCustomer(sql);

        }
        public int Add(CustomerDTO cus)
        {
            //ktra rang buoc tự nhiên
            if (cus.TenKH == " ")
            {
                return -2; // khong thanh cong se return -2, thành công sẽ return 1 trong DataProvider
            }
            //ktra rang buoc nghiep vu , trong nay có thể ktra đủ 18 tuổi k , có bằng cấp chưa ...
            try
            {
                return (new CustomerDAO().Add(cus));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
