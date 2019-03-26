namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SQDLX_DT")]
    public partial class TJ_SQDLX_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string FLBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string BH { get; set; }

        public int XH { get; set; }

        [Required]
        [StringLength(6)]
        public string TJLX { get; set; }
    }
}
