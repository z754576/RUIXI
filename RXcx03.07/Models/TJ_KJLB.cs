namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KJLB")]
    public partial class TJ_KJLB
    {
        [Key]
        [StringLength(12)]
        public string BH { get; set; }

        [Required]
        [StringLength(50)]
        public string TJKBH { get; set; }

        public int DJCS { get; set; }

        [StringLength(50)]
        public string GYBH { get; set; }

        [Required]
        [StringLength(4)]
        public string TJKLB { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }

        public decimal? JE { get; set; }

        public DateTime CZRQ { get; set; }

        [Required]
        [StringLength(6)]
        public string CZY { get; set; }
    }
}
