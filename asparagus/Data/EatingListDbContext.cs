﻿using asparagus.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asparagus.Data {
    public class EatingListDbContext : DbContext {
        public EatingListDbContext(DbContextOptions<EatingListDbContext> options)
            : base(options) {
        }

        public DbSet<EatingsList> EatingNote { get; set; }
    }
}