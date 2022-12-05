﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string Specifications { get; set; }

        [Required]
        public string URL { get; set; }

        [Required]
        public int Price { get; set; }

        [ForeignKey("ComputerBrand")]
        public int BrandID { get; set; }

        public virtual Brand ComputerBrand { get; set; }

        public List<Seller> Sellers { get; set; }
    }
}
