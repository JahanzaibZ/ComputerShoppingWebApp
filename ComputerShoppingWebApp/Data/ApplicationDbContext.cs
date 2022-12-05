using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ComputerShoppingWebApp.Models;

namespace ComputerShoppingWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ComputerShoppingWebApp.Models.Computer> Computer { get; set; }
        public DbSet<ComputerShoppingWebApp.Models.Seller> Seller { get; set; }
        public DbSet<ComputerShoppingWebApp.Models.Brand> Brand { get; set; }
    }
}
