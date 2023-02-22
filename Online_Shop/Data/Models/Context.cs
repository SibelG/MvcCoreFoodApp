using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Data.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EN1BN05\\MSSQLSERVER01; database=CoreFood; integrated security=True");

        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set;  }
        public DbSet<Admin> Admins { get; set; }

    }
}
