namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJJLB_XGRZ")]
    public partial class TJ_TJJLB_XGRZ
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime XGRQ { get; set; }
    }
}
