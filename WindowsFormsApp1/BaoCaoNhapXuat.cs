using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class BaoCaoNhapXuat : BaoCao
    {
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int TongSoLuongNhap { get; set; }
        public int TongSoLuongXuat { get; set; }
        public decimal TongGiaTriNhap { get; set; }
        public decimal TongGiaTriXuat { get; set; }
    }
}
