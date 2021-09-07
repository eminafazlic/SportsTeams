using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Database.Country> Countries { get; set; }
        public DbSet<Database.Team> Teams { get; set; }
        public DbSet<Database.Player> Players { get; set; }
    }
}
