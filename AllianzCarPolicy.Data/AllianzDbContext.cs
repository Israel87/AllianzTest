//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AllianzCarPolicy.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Dac.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Data
{
    public class AllianzDBContext : IdentityDbContext
    {
        public AllianzDBContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<CarMake> Makes { get; set; }
        public virtual DbSet<CarModel> Models { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<VehicleInfo> VehicleInfos { get; set; }
        public virtual DbSet<CarBodyType> BodyTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarBodyType>()
                .Property(p => p.PremiumValue)
                .HasColumnType("decimal(18,4)");


        }


    }


}
