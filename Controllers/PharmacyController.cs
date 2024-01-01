using Microsoft.AspNetCore.Mvc;
using Pharmacy_API_nuvem.Models;
using Pharmacy_API_nuvem.Services;

namespace Pharmacy_API_nuvem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PharmacyController : ControllerBase
    {
        private readonly PharmacyService _service;

        public PharmacyController(PharmacyService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var pharmacy = _service.GetById(id);
            if (pharmacy == null)
            {
                return NotFound();
            }
            return Ok(pharmacy);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var pharmacies = _service.GetAll();
            return Ok(pharmacies);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pharmacy pharmacy)
        {
            if (id != pharmacy.Id)
            {
                return BadRequest();
            }

            _service.Update(pharmacy);
            return NoContent();
        }
    }
}
