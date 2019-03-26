namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DJYYXX")]
    public partial class TJ_DJYYXX
    {
        [Key]
        public int XH { get; set; }

        [Required]
        [StringLength(6)]
        public string QYBH { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(500)]
        public string YYXX { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }

        [Required]
        [StringLength(20)]
        public string CZY { get; set; }

        public DateTime CZSJ { get; set; }
    }
}
