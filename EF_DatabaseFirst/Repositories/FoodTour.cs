using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EF_DatabaseFirst.Repositories
{
    public partial class FoodTour
    {
        [Key]
        public Guid? Id { get; set; }
        [Required]
        public string MaMonAn { get; set; }
        [Required]
        public string TenMonAn { get; set; }
        [Required]
        public bool? TrangThai { get; set; }
    }
}
