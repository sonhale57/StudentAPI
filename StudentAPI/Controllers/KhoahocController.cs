using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoahocController : ControllerBase
    {
        private readonly APIDbContext _context;

        public KhoahocController(APIDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Khoahoc>>> GetLists()
        {
            return await _context.Khoahoc.ToListAsync();
        }
        // GET: api/Student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Khoahoc>> GetKhoahocs(int id)
        {
            var khoahoc = await _context.Khoahoc.FindAsync(id);

            if (khoahoc == null)
            {
                return NotFound();
            }

            return khoahoc;
        }
    }

}
