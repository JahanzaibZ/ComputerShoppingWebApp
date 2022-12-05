using System.ComponentModel.DataAnnotations;

namespace ComputerShoppingWebApp.Models
{
    public class Brand
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string LogoURL { get; set; }
        
        [Required]
        public string HeadOffice { get; set; }
    }
}
