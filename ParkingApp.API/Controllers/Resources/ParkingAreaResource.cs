using System.ComponentModel.DataAnnotations;

namespace ParkingApp.API.Controllers.Resources
{
    public class ParkingAreaResource
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public decimal WeekdaysHourlyRate { get; set; }

        public decimal WeekendHourlyRate { get; set; }

        public decimal? Discount { get; set; }
    }
}