using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kinobar.Models;
namespace Kinobar.Database
{
    public class KinobarContext : DbContext
    {
        public KinobarContext(DbContextOptions<KinobarContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Movie> Movies{ get; set; }

        public DbSet<Country> Countries { get; set; }
    }
}
