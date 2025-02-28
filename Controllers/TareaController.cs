using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webapi.Application.Repositories;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly ITareaService _TareaService;

        public TareaController(ITareaService TareaService)
        {
            _TareaService = TareaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _TareaService.index());
        }
    }
}
