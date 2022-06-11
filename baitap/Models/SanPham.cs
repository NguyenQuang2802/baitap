using System;
using System.ComponentModel.DataAnnotations;

namespace baitap.Models
{
    public class SanPham
    {
        [Key]
        public int IdSP { get; set; }
        public string TenSP { get; set; }
        public string NhaCC { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }

    }
}
