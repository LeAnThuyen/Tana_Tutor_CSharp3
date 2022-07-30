using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EF_DatabaseFirst.DomainClass
{

    //folder này là nơi chứa duy nhất  các đối tượng của các em dùng trong bài
    //và là các bảng của em trong cơ sở dữ liệu
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
