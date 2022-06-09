using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace baitap.Migrations
{
    public class SanPhams
    {
        [Key]
        public int Idsp { get; set; }
        [Required]
        [StringLength(50)]
        public string Tensp { get; set; }

        public int Gianap { get; set; }
        public int Giaban { get; set; }
        public int Soluong { get; set; }
    }
}
