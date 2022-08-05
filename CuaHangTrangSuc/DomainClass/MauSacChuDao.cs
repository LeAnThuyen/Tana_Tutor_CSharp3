using System;
using System.Collections.Generic;

#nullable disable

namespace CuaHangTrangSuc.DomainClass
{
    public partial class MauSacChuDao
    {
        public MauSacChuDao()
        {
            TrangSucs = new HashSet<TrangSuc>();
        }

        public Guid IdMauSac { get; set; }
        public string MaMauSac { get; set; }
        public string TenMauSac { get; set; }
        public bool? TrangThai { get; set; }

        public virtual ICollection<TrangSuc> TrangSucs { get; set; }
    }
}
