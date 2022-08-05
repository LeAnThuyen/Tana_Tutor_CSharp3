using System;
using System.Collections.Generic;

#nullable disable

namespace CuaHangTrangSuc.DomainClass
{
    public partial class NhaSanXuat
    {
        public NhaSanXuat()
        {
            TrangSucs = new HashSet<TrangSuc>();
        }

        public Guid IdNhaSanXuat { get; set; }
        public string MaNhaSanXuat { get; set; }
        public string TenNhaSanXuat { get; set; }
        public bool? TrangThai { get; set; }

        public virtual ICollection<TrangSuc> TrangSucs { get; set; }
    }
}
