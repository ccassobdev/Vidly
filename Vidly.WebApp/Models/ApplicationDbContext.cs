﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Vidly.WebApp.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MemberShipType> MemberShipTypes { get; set; }
        public DbSet<GenreType> GenreTypes { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Customer>()
            //    .HasRequired(c => c.MemberShipType)
            //    .WithRequiredPrincipal();

        }
    }
}