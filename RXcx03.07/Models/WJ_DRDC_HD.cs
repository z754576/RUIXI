namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.WJ_DRDC_HD")]
    public partial class WJ_DRDC_HD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string JSJMC { get; set; }

        [StringLength(10)]
        public string DRDCBZ { get; set; }

        [StringLength(10)]
        public string HS { get; set; }

        [StringLength(10)]
        public string LY { get; set; }

        [StringLength(10)]
        public string CZY { get; set; }

        public DateTime? CZSJ { get; set; }
    }
}
