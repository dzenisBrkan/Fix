using FIX.API.Data;
using FIX.API.Models.Domain;
using FIX.API.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FIX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MechanicsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MechanicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IList<Mechanics> Index()
        {
            var list = _context.Mechanics.ToList();

            return list;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMechanic(CreateMehanicDto request)
        {
            var mechanic = new Mechanics
            {
                mechanic_name = request.mechanic_name,
                mechanic_surname = request.mechanic_surname,
                mechanic_shop_name = request.mechanic_shop_name,
                mechanic_type = request.mechanic_type,
                location = request.location,
                is_logged_in = request.is_logged_in,
                rating = request.rating,
                working_hours = request.working_hours,
                services_offered = request.services_offered,
                profile_created_at = DateTime.Now
            };

            await _context.Mechanics.AddAsync (mechanic);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
} 