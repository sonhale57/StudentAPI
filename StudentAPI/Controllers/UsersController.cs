using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly APIDbContext _context;
        public UsersController(APIDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hocsinh>>> GetHocsinhs()
        {
            return await _context.Hocsinh.ToListAsync();
        }

        [HttpGet("Login/{username}/{password}")]
        public async Task<ActionResult<Hocsinh>> Login(string Username, string Password)
        {
            var student = await _context.Hocsinh
                .Where(m => m.userLog == Username && m.matkhau == Password && m.userLog != null && m.matkhau != null)
                .SingleOrDefaultAsync();

            if (student == null)
            {
                return NotFound();
            }

            // Additional null checks for specific properties
           
            return _context.Hocsinh.Find(student.id);
        }
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult<Hocsinh>> Register([FromForm] Register register)
        {
            Hocsinh hocsinh = new Hocsinh()
            {
                enable = 1,
                updatetime = DateTime.Now,
                dateCreate = DateTime.Now,
                ten = register.Name,
                dienthoai = register.Phone,
                PHHS_dienthoai = register.Phone,
                email = register.Email,
                PHHS_bietappqua = register.PHHS_bietappqua,
                PHHS_bietqua = register.PHHS_bietqua,
                IsUseful = register.IsUseful,
                namsinh = register.DateOfBirth,
                PHHS_diachi = register.Address,
                PHHS_quan = register.City,
                sex = register.Sex,
                userLog = register.Name + register.Phone,
                matkhau = "taptrung",
                Tunghoc = register.Tunghoc
            };
            _context.Hocsinh.Add(hocsinh);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHocsinhs", new { id = hocsinh.id }, hocsinh);
        }
    }
}
