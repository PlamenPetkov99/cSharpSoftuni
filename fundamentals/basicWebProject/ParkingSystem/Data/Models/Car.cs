using System.ComponentModel.DataAnnotations;

namespace ParkingSystem.Data.Models
{
    public class Car
    {
        [Required]//because we dont want to make a car without car make or plate number
        public string CarMake { get; set; }

        [Required]
        public string PlateNumber { get; set; }

    }

}
