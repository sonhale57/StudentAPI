using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models
{
    [Table("ChiNhanh")]
    public class ChiNhanh
    {
        [Key]
        public int id { get; set; }

        public DateTime? updatetime { get; set; }

        public int? iduser { get; set; }

        [StringLength(500)]
        public string? logo { get; set; }

        [StringLength(10)]
        public string? thongtin_block1 { get; set; }

        [StringLength(500)]
        public string? Machinhanh { get; set; }

        [StringLength(1500)]
        public string? Ten { get; set; }

        public bool? enable { get; set; }

        [StringLength(500)]
        public string? tencongty { get; set; }

        [StringLength(500)]
        public string? diachi { get; set; }

        [StringLength(500)]
        public string? tinh { get; set; }

        [StringLength(500)]
        public string? map { get; set; }

        [StringLength(500)]
        public string? dienthoai { get; set; }

        [StringLength(500)]
        public string? email { get; set; }

        [StringLength(500)]
        public string? mst { get; set; }

        [StringLength(500)]
        public string? giayphepgiaoduc { get; set; }

        [StringLength(10)]
        public string? caidat_block { get; set; }

        public int? limituser { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? soluonglop { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? testdauvao { get; set; }

        [StringLength(50)]
        public string? SMS { get; set; }

        [Column(TypeName = "ntext")]
        public string? diengiai { get; set; }

        [StringLength(500)]
        public string? dcgiaohang { get; set; }

        [StringLength(50)]
        public string? phonegiaohang { get; set; }

        public int? uudai { get; set; }

        public DateTime? fromdate { get; set; }

        public DateTime? todate { get; set; }

        public DateTime? DateExpire { get; set; }

        public bool? Active { get; set; }

        [StringLength(500)]
        public string? email1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? chiphi { get; set; }

        public int? groupchiphi { get; set; }

        public DateTime? hanhopdong { get; set; }

        [StringLength(50)]
        public string? sohopdong { get; set; }

        public DateTime? DateTKOnline { get; set; }

        [StringLength(50)]
        public string? lienheThiTQ { get; set; }

        [StringLength(50)]
        public string? dienthoaiThiTQ { get; set; }

        public int? IdCum { get; set; }

        public int? CumOrder { get; set; }
    }
}
