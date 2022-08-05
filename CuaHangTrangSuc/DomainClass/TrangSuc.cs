using System;

#nullable disable

namespace CuaHangTrangSuc.DomainClass
{
    public partial class TrangSuc
    {
        public Guid Id { get; set; }
        public string MaTrangSuc { get; set; }
        public string TenTrangSuc { get; set; }
        public double? Gia { get; set; }
        public bool? TrangThai { get; set; }
        public Guid? IdMauChuDao { get; set; }
        public Guid? IdNhaSanXuat { get; set; }

        public virtual MauSacChuDao IdMauChuDaoNavigation { get; set; }
        public virtual NhaSanXuat IdNhaSanXuatNavigation { get; set; }
    }
}
