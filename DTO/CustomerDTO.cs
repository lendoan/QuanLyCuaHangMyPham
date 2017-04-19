using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public CustomerDTO(string id, string name, string ad, string phone,string namsinhKH,string gtKH)
        {
            MaKH = id;
            TenKH = name;
            DiaChi = ad;
            DienThoai = phone;
            NamSinh = namsinhKH;
            GioiTinh = gtKH;
        }
    }
}
