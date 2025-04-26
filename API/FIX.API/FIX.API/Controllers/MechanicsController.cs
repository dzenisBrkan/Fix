using FIX.Application.Interfaces.Mechanic;
using Microsoft.AspNetCore.Mvc;

namespace FIX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MechanicsController : ControllerBase
    {
        private readonly IMechanicService _mechanicService;

        public MechanicsController(IMechanicService mechanicService)
        {
            _mechanicService = mechanicService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var mechanics = await _mechanicService.GetAllMechanicsAsync();
            return Ok(mechanics);
        }
    }
}