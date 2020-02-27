﻿using System;
using System.Collections.Generic;
using System.Text;
using asparagus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace asparagus.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
            //Database.EnsureDeleted();
            Database.EnsureCreated();

        }
    }
}
