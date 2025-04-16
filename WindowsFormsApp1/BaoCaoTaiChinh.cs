using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class BaoCaoTaiChinh : BaoCao
    {
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal TongChiPhiNhap { get; set; }
        public decimal TongDoanhThu { get; set; }
        public decimal TongCongNoNhaCungCap { get; set; }
        public decimal TongCongNoKhachHang { get; set; }
    }
}
