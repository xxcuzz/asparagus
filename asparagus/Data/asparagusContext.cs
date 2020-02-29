using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asparagus.Models;

namespace asparagus.Data
{
    public class asparagusContext : DbContext
    {
        public asparagusContext (DbContextOptions<asparagusContext> options)
            : base(options)
        {
        }

        public DbSet<asparagus.Models.EatingsList> EatingsList { get; set; }
    }
}
