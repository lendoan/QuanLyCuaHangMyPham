using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MoTa { get; set; }
        public double DonGia { get; set; }
        public string TinhTrang { get; set; }
        public string MaNguonCungCap { get; set; }
        public string MaLoaiSP { get; set; }
        public SanPhamDTO(string masp, string tensp, string mota, double dongia, string tinhtrang, string manguoncungcap, string maloaisp)
        {
            MaSP = masp;
            TenSP = tensp;
            MoTa = mota;
            DonGia = dongia;
            TinhTrang = tinhtrang;
            MaNguonCungCap = manguoncungcap;
            MaLoaiSP = maloaisp;
        }

    }
}
