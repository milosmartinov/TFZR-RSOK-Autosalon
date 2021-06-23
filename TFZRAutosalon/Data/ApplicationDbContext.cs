﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using TFZRAutosalon.Models;

namespace TFZRAutosalon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<CarModels> CarModels { get; set; }
        public DbSet<Categorizes> Categorizes { get; set; }
        public DbSet<Manufacturers> Manufacturers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>().ToTable(name: "Users");
            builder.Entity<IdentityRole>().ToTable(name: "Roles");
            builder.Entity<IdentityUserToken<string>>().ToTable(name: "UserToken");
            builder.Entity<IdentityUserLogin<string>>().ToTable(name: "UserLogin");
            builder.Entity<IdentityUserRole<string>>().ToTable(name: "UserRole");
            builder.Entity<IdentityUserClaim<string>>().ToTable(name: "UserClaim");
            builder.Entity<IdentityRoleClaim<string>>().ToTable(name: "RoleClaim");
        }
    }
}
