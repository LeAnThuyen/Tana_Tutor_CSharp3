using System.Collections.Generic;

#nullable disable

namespace Showroom.DomainClass
{
    public partial class HangXe
    {
        public HangXe()
        {
            Xes = new HashSet<Xe>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Xe> Xes { get; set; }
    }
}
