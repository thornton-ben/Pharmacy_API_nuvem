using Pharmacy_API_nuvem.Data;
using Pharmacy_API_nuvem.Models;

namespace Pharmacy_API_nuvem.Repository
{
    public class PharmacyRepository
    {
        private readonly PharmacyDbContext _context;

        public PharmacyRepository(PharmacyDbContext context)
        {
            _context = context;
        }

        public Pharmacy GetById(int id)
        {
            return _context.Pharmacies.Find(id);
        }

        public IEnumerable<Pharmacy> GetAll()
        {
            return _context.Pharmacies.ToList();
        }

        public void Update(Pharmacy pharmacy)
        {
            _context.Pharmacies.Update(pharmacy);
            _context.SaveChanges();
        }
    }
}
