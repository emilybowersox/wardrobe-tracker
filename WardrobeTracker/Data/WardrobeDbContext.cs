using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WardrobeTracker.Models;

namespace WardrobeTracker.Data
{
    public class WardrobeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=.;Database=WardrobeTracker;Trusted_Connection=True;");

/*       
        public DbSet<Outfit> Outfits { get; set; }*/


        public DbSet<WardrobeItem> WardrobeItem { get; set; }

    }
}
