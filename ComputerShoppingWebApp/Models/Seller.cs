using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComputerShoppingWebApp.Models
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Computer> Computers { get; set; }
    }
}
