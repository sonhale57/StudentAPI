using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<ChiNhanh> ChiNhanh { get; set; }
        public DbSet<Hocsinh> Hocsinh { get; set; }
        public DbSet<Hocsinh_khoahoc> Hocsinh_Khoahoc { get; set; }
        public DbSet<Khoahoc> Khoahoc { get; set; }
        public DbSet<Lophoc> Lophoc { get; set; }
        public DbSet<UserAvatar> UserAvatar { get; set; }
        public DbSet<UserMood> UserMood { get; set; }
    }
}
