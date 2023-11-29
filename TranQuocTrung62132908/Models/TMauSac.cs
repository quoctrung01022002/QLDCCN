using System;
using System.Collections.Generic;

namespace TranQuocTrung62132908.Models
{
    public partial class TMauSac
    {
        public TMauSac()
        {
            TChiTietSanPhams = new HashSet<TChiTietSanPham>();
        }

        public string MaMauSac { get; set; } = null!;
        public string? TenMauSac { get; set; }

        public virtual ICollection<TChiTietSanPham> TChiTietSanPhams { get; set; }
    }
}
