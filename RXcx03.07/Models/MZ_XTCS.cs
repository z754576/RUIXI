namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.MZ_XTCS")]
    public partial class MZ_XTCS
    {
        [Key]
        [StringLength(32)]
        public string ZDM { get; set; }

        [StringLength(32)]
        public string MC { get; set; }

        [Required]
        [StringLength(1)]
        public string ZDLX { get; set; }

        [Required]
        [StringLength(8000)]
        public string SZ { get; set; }

        [StringLength(255)]
        public string SM { get; set; }

        [Required]
        [StringLength(1)]
        public string XSFG { get; set; }

        [StringLength(254)]
        public string TSNR { get; set; }

        [Required]
        [StringLength(1)]
        public string QX { get; set; }

        [StringLength(1)]
        public string XSZT { get; set; }

        [StringLength(6)]
        public string DISP_ORDER { get; set; }

        [StringLength(40)]
        public string FLMC { get; set; }

        [StringLength(1)]
        public string SFWK { get; set; }
    }
}
