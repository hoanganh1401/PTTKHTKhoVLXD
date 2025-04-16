using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class ChiTietBaoCaoTaiChinh
    {
        public int MaBaoCao { get; set; }
        public string LoaiGiaoDich { get; set; } // "Thu", "Chi", "No NCC", "No KH"
        public DateTime NgayGiaoDich { get; set; }
        public decimal SoTien { get; set; }
        public string MoTaGiaoDich { get; set; }
    }
}
