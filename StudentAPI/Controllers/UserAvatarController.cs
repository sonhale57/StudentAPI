using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAvatarController : ControllerBase
    {
        private readonly APIDbContext _context;

        public UserAvatarController(APIDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserAvatar>>> GetUserAvatar()
        {
            return await _context.UserAvatar.ToListAsync();
        }

        [HttpPost]
        [Route("PUT")]
        public async Task<ActionResult<UserAvatar>> PUT(int user_Id,string avatar_type)
        {
            var userAvatar = new UserAvatar()
            {
                User_id =user_Id,
                Avatar_type =avatar_type
            };
            _context.UserAvatar.Add(userAvatar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserAvatar", new { id = userAvatar.Id }, userAvatar);
        }
    }
}
