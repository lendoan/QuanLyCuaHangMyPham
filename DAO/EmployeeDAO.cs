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
   public class EmployeeDAO
    {
        private DataProvider dp;
        public EmployeeDAO()
        {
            dp = new DataProvider();
        }
        public List<EmployeeDTO> GetEmployee(string sql)
        {
            dp.connect();
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            {
                
                string id,lastname, firstname,chucvu,gt,birthday, ngaylamviec, ad, phone;
                try
                {
                    SqlDataReader dr = dp.ExecuteReader(sql);
                    while (dr.Read())
                    {
                        id = dr.GetString(0);
                        lastname = dr.GetString(1);
                        firstname = dr.GetString(2);
                        chucvu = dr.GetString(3);
                        gt = dr.GetString(4);
                        birthday = dr.GetString(5);
                        ngaylamviec = dr.GetString(6);
                        
                        phone = dr.GetString(8);
                        ad = dr.GetString(7);
                        EmployeeDTO em = new EmployeeDTO(id, lastname, firstname,chucvu,gt,birthday,ngaylamviec, phone, ad);
                        list.Add(em);
                    
                       
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
        public int Add(EmployeeDTO emp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@id", emp.MaNhanVien));
            paras.Add(new SqlParameter("@lastname", emp.HoNV));
            paras.Add(new SqlParameter("@firstname", emp.TenNV));
            paras.Add(new SqlParameter("@chucvu", emp.MaCV));
            paras.Add(new SqlParameter("@gt", emp.GioiTinh));
            paras.Add(new SqlParameter("@birthday", emp.NgaySinh));
            paras.Add(new SqlParameter("@ngaylamviec", emp.NgayLamViec));
            paras.Add(new SqlParameter("@phone", emp.SoDienThoai));
            paras.Add(new SqlParameter("@ad", emp.DiaChi));
            
            
            try
            {
                return (dp.ExcuteNonQuery("ThemNV1", System.Data.CommandType.StoredProcedure, paras));
                // " ten thu tuc " , loại , danh sach 
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

       
      
    }
}
