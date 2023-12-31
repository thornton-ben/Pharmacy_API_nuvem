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

        public Pharmacy GetPharmacyById(int id)
        {
            return _repository.GetPharmacyById(id);
        }

        public List<Pharmacy> GetAllPharmacies()
        {
            return _repository.GetAllPharmacies();
        }

        public void UpdatePharmacy(Pharmacy pharmacy)
        {
            _repository.UpdatePharmacy(pharmacy);
        }
    }
}
