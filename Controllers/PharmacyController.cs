using Microsoft.AspNetCore.Mvc;
using Pharmacy_API_nuvem.Models;
using Pharmacy_API_nuvem.Services;

namespace Pharmacy_API_nuvem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacyController : ControllerBase
    {
        private readonly PharmacyService _pharmacyService;

        public PharmacyController(PharmacyService pharmacyService)
        {
            _pharmacyService = pharmacyService;
        }

        [HttpGet("{id}")]
        public IActionResult GetPharmacyById(int id)
        {
            var pharmacy = _pharmacyService.GetPharmacyById(id);
            if (pharmacy == null)
                return NotFound();

            return Ok(pharmacy);
        }

        [HttpGet]
        public IActionResult GetAllPharmacies()
        {
            var pharmacies = _pharmacyService.GetAllPharmacies();
            return Ok(pharmacies);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePharmacy(int id, [FromBody] Pharmacy updatedPharmacy)
        {
            var existingPharmacy = _pharmacyService.GetPharmacyById(id);
            if (existingPharmacy == null)
                return NotFound();

            existingPharmacy.Name = updatedPharmacy.Name;
            // Update other properties...

            _pharmacyService.UpdatePharmacy(existingPharmacy);

            return NoContent();
        }
    }
}
