using Microsoft.EntityFrameworkCore;
using Pharmacy_API_nuvem.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Pharmacy_API_nuvem.Data
{
    public class PharmacyDbContext : DbContext
    {
        public DbSet<Pharmacy> Pharmacies { get; set; }

        public PharmacyDbContext(DbContextOptions<PharmacyDbContext> options, DbSet<Pharmacy> pharmacies) : base(options)
        {
            Pharmacies = pharmacies;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pharmacy>().HasData(
                new Pharmacy
                {
                    Id = 1,
                    Name = "Pharmacy 1",
                    Address = "123 Rock Rd",
                    City = "Frisco",
                    State = "Texas",
                    Zip = "75035",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Pharmacy
                {
                    Id = 2,
                    Name = "Pharmacy 2",
                    Address = "123 Rock Rd",
                    City = "Frisco",
                    State = "Texas",
                    Zip = "75035",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Pharmacy
                {
                    Id = 3,
                    Name = "Pharmacy 3",
                    Address = "123 Rock Rd",
                    City = "Frisco",
                    State = "Texas",
                    Zip = "75035",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Pharmacy
                {
                    Id = 4,
                    Name = "Pharmacy 4",
                    Address = "123 Rock Rd",
                    City = "Frisco",
                    State = "Texas",
                    Zip = "75035",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Pharmacy
                {
                    Id = 5,
                    Name = "Pharmacy 5",
                    Address = "123 Rock Rd",
                    City = "Frisco",
                    State = "Texas",
                    Zip = "75035",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );
        }
    }
