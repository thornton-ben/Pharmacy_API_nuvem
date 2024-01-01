using Microsoft.EntityFrameworkCore;
using Pharmacy_API_nuvem.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Pharmacy_API_nuvem.Data
{
    public class PharmacyDbContext : DbContext
    {
        public DbSet<Pharmacy> Pharmacies { get; set; }

        public PharmacyDbContext(DbContextOptions<PharmacyDbContext> options) : base(options)
        {
        }
    }

}
