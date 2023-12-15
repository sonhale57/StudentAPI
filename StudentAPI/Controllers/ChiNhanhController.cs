using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiNhanhController : ControllerBase
    {
        private readonly APIDbContext _context;
        public ChiNhanhController(APIDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChiNhanh>>> GetChiNhanhs()
        {
            var chiNhanhs = await _context.ChiNhanh.ToListAsync();

            if (chiNhanhs == null)
            {
                return NotFound();
            }

            // Kiểm tra giá trị null trước khi sử dụng
            var nonNullChiNhanhs = chiNhanhs
                .Where(c => c.id != null)
                .ToList();

            return nonNullChiNhanhs;
        }
    }
}
