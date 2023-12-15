using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Models
{
    [Table("UserAvatar")]
    public class UserAvatar
    {
        [Key]
        public int Id { get; set; }

        public int? User_id { get; set; }

        public string? Avatar_type { get; set; }
    }
}
