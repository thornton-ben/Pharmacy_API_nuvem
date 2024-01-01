using Pharmacy_API_nuvem.Models;
using Pharmacy_API_nuvem.Repository;

namespace Pharmacy_API_nuvem.Services
{
    public class PharmacyService
    {
        private readonly PharmacyRepository _repository;

        public PharmacyService(PharmacyRepository repository)
        {
            _repository = repository;
        }

        public Pharmacy GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Pharmacy> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Pharmacy pharmacy)
        {
            _repository.Update(pharmacy);
        }
    }
}
