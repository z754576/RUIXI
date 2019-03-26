namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.WJ_DRDC_DT")]
    public partial class WJ_DRDC_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string JSJMC { get; set; }

        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(40)]
        public string XM2 { get; set; }

        [StringLength(14)]
        public string TJBH { get; set; }

        public int? TJCS { get; set; }
    }
}
