﻿using asparagus.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace asparagus.Data {
    public class EatingListDbContext : DbContext {
        public EatingListDbContext(DbContextOptions<EatingListDbContext> options)
            : base(options) {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        public DbSet<EatingsList> EatingNote { get; set; }

    }
}
