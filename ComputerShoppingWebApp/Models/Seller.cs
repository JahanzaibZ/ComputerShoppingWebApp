using System.ComponentModel.DataAnnotations;

namespace ComputerShoppingWebApp.Models
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
