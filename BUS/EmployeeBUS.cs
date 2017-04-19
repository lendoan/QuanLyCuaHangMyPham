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
    public class EmployeeBUS
    {
        public List<EmployeeDTO> GetEmployee(string sql)
        {

            return new EmployeeDAO().GetEmployee(sql);

        }
        public int Add(EmployeeDTO emp)
        {
            //ktra rang buoc tự nhiên
            if (emp.HoNV == " " || emp.TenNV == " ")
            {
                return -2; // khong thanh cong se return -2, thành công sẽ return 1 trong DataProvider
            }
            //ktra rang buoc nghiep vu , trong nay có thể ktra đủ 18 tuổi k , có bằng cấp chưa ...
            try
            {
                return (new EmployeeDAO().Add(emp));
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
