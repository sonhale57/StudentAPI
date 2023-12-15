using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMoodController : ControllerBase
    {
        private readonly APIDbContext _context;

        public UserMoodController(APIDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserMood>>> GetMoods()
        {
            return await _context.UserMood.ToListAsync();
        }
        [HttpPost]
        [Route("PUT")]
        public async Task<ActionResult<UserMood>> PutUserMood(int User_id,string Mood_key,string Mood_name)
        {
            var userMood = new UserMood() { 
                User_id= User_id,
                Mood_key=Mood_key,
                Mood_name=Mood_name,
                Time_stamps=DateTime.Now
            };
            _context.UserMood.Add(userMood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMoods", new { id = userMood.Id }, userMood);
        }
    }
}
