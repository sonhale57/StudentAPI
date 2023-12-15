using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Models
{
    [Table("Lophoc_join")]
    public class Hocsinh_khoahoc
    {
        public int id { get; set; }

        public int idhocvien { get; set; }

        public int? iddangky { get; set; }

        public int? idlop { get; set; }

        public DateTime? updatetime { get; set; }

        public DateTime? fromdate { get; set; }

        public DateTime? todate { get; set; }

        public int? idkhoahoc { get; set; }

        public int? sobuoi { get; set; }
    }
}
