using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LophocController : ControllerBase
    {
        private readonly APIDbContext _context;
        public LophocController(APIDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lophoc>>> GetLopHocs()
        {
            return await _context.Lophoc.ToListAsync();
        }
    }
}
