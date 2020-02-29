using asparagus.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace asparagus.Data {
    public class EatingListDbContext : DbContext {
        public EatingListDbContext(DbContextOptions<EatingListDbContext> options)
            : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<EatingsList> EatingNote { get; set; }

    }
}
