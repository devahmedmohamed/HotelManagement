using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D16EF02Task.Entities;
using Microsoft.EntityFrameworkCore;

namespace D16EF02Task.Context
{
    public class HotelContext : DbContext   
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SETJPFR\\SQLEXPRESS; Initial Catalog = HotelDB; Integrated Security = true; Encrypt = false");

        }
        public DbSet<ManagerLoginFrontend> ManagerLoginFrontend { get; set; }
        public DbSet<ManagerLoginKitchen> ManagerLoginKitchen { get; set; }
        public DbSet<HotelReservation> HotelReservation { get; set; }
    }
}
