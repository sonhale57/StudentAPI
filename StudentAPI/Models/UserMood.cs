using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StudentAPI.Models
{
    [Table("UserMood")]
    public class UserMood
    {
        [Key]
        public int Id { get; set; }

        public int? User_id { get; set; }

        [StringLength(500)]
        public string? Mood_key { get; set; }

        [StringLength(500)]
        public string? Mood_name { get; set; }

        public DateTime? Time_stamps { get; set; }
    }
}
