namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SJH_FPXM")]
    public partial class TJ_SJH_FPXM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string SJH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string FPXM { get; set; }

        public decimal? JE { get; set; }
    }
}
