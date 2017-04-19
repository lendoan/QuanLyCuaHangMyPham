using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHang_DTO
    {
         public string  MaDH { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public string NgayDatHang { get; set; }
        public string  NgayGiaoHang { get; set; }

        public DonHang_DTO(string madh,string makh,string manv,string ndat,string ngiao )
        {
            MaDH = madh;
            MaKH = makh;
            MaNV = manv;
            NgayDatHang = ndat;
            NgayGiaoHang = ngiao;
        }
    }
}
