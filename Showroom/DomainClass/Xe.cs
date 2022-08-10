using System;
using System.Collections.Generic;

#nullable disable

namespace Showroom.DomainClass
{
    public partial class Xe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdHangXe { get; set; }
        public int Giaxe { get; set; }
        public double? Thue { get; set; }

        public virtual HangXe IdHangXeNavigation { get; set; }
    }
}
