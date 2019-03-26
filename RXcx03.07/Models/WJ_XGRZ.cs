namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.WJ_XGRZ")]
    public partial class WJ_XGRZ
    {
        [Key]
        [StringLength(12)]
        public string BH { get; set; }

        [StringLength(14)]
        public string TJBH { get; set; }

        public int? TJCS { get; set; }

        [StringLength(12)]
        public string XM { get; set; }

        [Required]
        [StringLength(1)]
        public string LY { get; set; }

        [StringLength(12)]
        public string DCBH { get; set; }

        [StringLength(12)]
        public string DRBH { get; set; }
    }
}
