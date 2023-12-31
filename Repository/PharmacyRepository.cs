using Pharmacy_API_nuvem.Data;
using Pharmacy_API_nuvem.Models;

namespace Pharmacy_API_nuvem.Repository
{
    public class PharmacyRepository
    {
        private readonly PharmacyDbContext _dbContext;

        public PharmacyRepository(PharmacyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Pharmacy GetPharmacyById(int id)
        {
            return _dbContext.Pharmacies.Find(id);
        }

        public List<Pharmacy> GetAllPharmacies()
        {
            return _dbContext.Pharmacies.ToList();
        }

        public void UpdatePharmacy(Pharmacy pharmacy)
        {
            _dbContext.Pharmacies.Update(pharmacy);
            _dbContext.SaveChanges();
        }
    }
}
