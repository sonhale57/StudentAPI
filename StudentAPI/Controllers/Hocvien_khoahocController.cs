using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hocvien_khoahocController : ControllerBase
    {
        private readonly APIDbContext _context;

        public Hocvien_khoahocController(APIDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hocsinh_khoahoc>>> GetLists()
        {
            return await _context.Hocsinh_Khoahoc.ToListAsync();
        }
        // GET: api/Student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Hocsinh_khoahoc>>> GetKhoahocs(int id)
        {
            var student = await _context.Hocsinh_Khoahoc.Where(m=>m.idhocvien==id).ToListAsync();

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }
    }
}
