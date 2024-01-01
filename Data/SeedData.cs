using Pharmacy_API_nuvem.Models;

namespace Pharmacy_API_nuvem.Data
{
    public static class SeedData
    {
        public static void Initialize(PharmacyDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Pharmacies.Any())
            {
                return; // Database has been seeded
            }

            var pharmacies = new Pharmacy[]
            {
            new Pharmacy { Name = "Pharmacy1", Address = "123 Main St", City = "City1", State = "State1", Zip = "12345", FilledPrescriptions = 50, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Pharmacy { Name = "Pharmacy2", Address = "456 Oak St", City = "City2", State = "State2", Zip = "23456", FilledPrescriptions = 75, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Pharmacy { Name = "Pharmacy3", Address = "789 Pine St", City = "City3", State = "State3", Zip = "34567", FilledPrescriptions = 100, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Pharmacy { Name = "Pharmacy4", Address = "101 Elm St", City = "City4", State = "State4", Zip = "45678", FilledPrescriptions = 125, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Pharmacy { Name = "Pharmacy5", Address = "202 Birch St", City = "City5", State = "State5", Zip = "56789", FilledPrescriptions = 150, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            };

            context.Pharmacies.AddRange(pharmacies);
            context.SaveChanges();
        }
    }
}
