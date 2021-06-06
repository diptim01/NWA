using LocationApp2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationApp2
{
    public class LocationContext : DbContext
    {
        public LocationContext(DbContextOptions<LocationContext> options)
            : base(options)
        {

        }

        public DbSet<Country> Countries {get; set;}
        public DbSet<Town> Towns { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
