using System.ComponentModel.DataAnnotations;

namespace ComputerShoppingWebApp.Models
{
    public class Computer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string URL { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
