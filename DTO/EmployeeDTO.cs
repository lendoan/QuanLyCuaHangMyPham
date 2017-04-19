using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {
        public string MaNhanVien { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public string MaCV { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string NgayLamViec { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        

        public EmployeeDTO(string id, string lastname, string firstname,string chucvu,string gt,string birthday,string ngaylamviec, string phone,string ad)
        {
            MaNhanVien = id;
            HoNV = lastname;
            TenNV = firstname;
            MaCV = chucvu;
            GioiTinh = gt;
            NgaySinh = birthday;
            NgayLamViec = ngaylamviec;
            SoDienThoai = phone;
            DiaChi = ad;
          

        }
    }
}
