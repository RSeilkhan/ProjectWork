using Lunch.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Menu> Menus { get; set; }

    }
}
