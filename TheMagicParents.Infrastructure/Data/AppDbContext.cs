﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TheMagicParents.Models;

namespace TheMagicParents.Infrastructure.Data
{
    public class AppDbContext: IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Client>("Client")
                .HasValue<ServiceProvider>("ServiceProvider");


            // حل مشكلة العلاقات المتداخلة

            builder.Entity<Booking>()
           .HasOne(b => b.Client)
           .WithMany()
           .HasForeignKey(b => b.ClientID)
           .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Booking>()
                .HasOne(b => b.City)
                .WithMany()
                .HasForeignKey(b => b.CityID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Booking>()
                .HasOne(b => b.Payment)
                .WithOne(p => p.Booking)
                .HasForeignKey<Payment>(p => p.BookingID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Booking>()
                .HasOne(b => b.Review)
                .WithOne(r => r.Booking)
                .HasForeignKey<Review>(r => r.BookingID)
                .OnDelete(DeleteBehavior.Cascade);

        }


        public DbSet<Admin> Admins { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Goverment> Goverments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentTransactions> PaymentTransactions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
