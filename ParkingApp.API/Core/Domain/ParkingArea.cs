using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingApp.API.Core.Domain
{
    [Table("ParkingAreas")]
    public class ParkingArea
    {
        public int Id { get; set; }
        
        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(4, 2)")]
        public decimal WeekdaysHourlyRate { get; set; }

        [Column(TypeName = "decimal(4, 2)")]
        public decimal WeekendHourlyRate { get; set; }

        [Column(TypeName = "decimal(3, 2)")]
        public decimal? Discount { get; set; }
    }
}