namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KLB_DT")]
    public partial class TJ_KLB_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string LBBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string SXBH { get; set; }

        public decimal? KZJE { get; set; }

        [StringLength(1)]
        public string ZL { get; set; }

        public int? ZKLB { get; set; }
    }
}
