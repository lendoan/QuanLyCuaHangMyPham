using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using DTO;
using DAO;
namespace DAO
{
    public class CustomerDAO
    {
         private DataProvider dp;
        public CustomerDAO()
        {
            dp = new DataProvider();
        }
        public List<CustomerDTO> GetCustomer(string sql)
        {
            dp.connect();
            List<CustomerDTO> list = new List<CustomerDTO>();
            {
               
                string id,name,ad,phone,namsinhKH,gtKH;
                try
                {
                    SqlDataReader dr = dp.ExecuteReader(sql);
                    while (dr.Read())
                    {
                        id = dr.GetString(0);
                        name = dr.GetString(1);
                        ad = dr.GetString(2);
                        phone = dr.GetString(3);
                        namsinhKH = dr.GetString(4);
                        gtKH = dr.GetString(5);

                        CustomerDTO cu = new CustomerDTO(id,name,ad,phone,namsinhKH,gtKH);
                        list.Add(cu);
                    
                       
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
        public int Add(CustomerDTO cus)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", cus.MaKH));
            paras.Add(new SqlParameter("@name", cus.TenKH));
            paras.Add(new SqlParameter("@ad", cus.DiaChi));
            paras.Add(new SqlParameter("@phone", cus.DienThoai));
            paras.Add(new SqlParameter("@namsinhKH", cus.NamSinh));
            paras.Add(new SqlParameter("@gtKH", cus.GioiTinh));
            try
            {
                return (dp.ExcuteNonQuery("ThemKH", System.Data.CommandType.StoredProcedure, paras));
                // " ten thu tuc " , loại , danh sach 
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

       
    }
}
