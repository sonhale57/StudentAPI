using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models
{
    [Table("Khoahoc")]
    public class Khoahoc
    {
        public int id { get; set; }

        public int? idchuongtrinh { get; set; }

        public int? idChiNhanh { get; set; }

        [StringLength(500)]
        public string? ten { get; set; }

        [StringLength(50)]
        public string? makh { get; set; }

        public int? stt { get; set; }

        [StringLength(500)]
        public string? capdo { get; set; }

        [StringLength(50)]
        public string? sogio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HP_full { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? thoiluong { get; set; }

        public int? iduser { get; set; }

        public DateTime? updatetime { get; set; }

        public int? status { get; set; }

        public int? enable { get; set; }

        [StringLength(1000)]
        public string? ghichu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? diemquakhoa { get; set; }

        [StringLength(500)]
        public string? congthuc_giuaky { get; set; }

        [StringLength(500)]
        public string? tocdo_giuaky { get; set; }

        [StringLength(500)]
        public string? congthuc_cuoiky { get; set; }

        [StringLength(500)]
        public string? tocdo_cuoiky { get; set; }

        [StringLength(500)]
        public string? trangthai { get; set; }

        [StringLength(1500)]
        public string? dinhhuongkhoasau { get; set; }
    }
}
