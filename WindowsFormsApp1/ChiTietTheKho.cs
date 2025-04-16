using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class ChiTietTheKho
    {
        public int MaTheKho { get; set; }
        public DateTime NgayGhiNhan { get; set; }
        public string LoaiGiaoDich { get; set; } // "Nhap", "Xuat"
        public int SoLuong { get; set; }
        public int SoLuongTonSau { get; set; }
        public int MaPhieuLienQuan { get; set; }
        public string GhiChu { get; set; }
    }
}
