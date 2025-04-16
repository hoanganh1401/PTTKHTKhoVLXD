using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class ChiTietBaoCaoTonKho
    {
        public int MaBaoCao { get; set; }
        public int MaVatLieu { get; set; }
        public string TenVatLieu { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuongTon { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiaTriTon { get; set; }
        public string GoiYNhap { get; set; } // "Yes" hoặc "NO"
    }
}
