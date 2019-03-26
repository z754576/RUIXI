namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JBMB_HD")]
    public partial class TJ_JBMB_HD
    {
        [Key]
        [StringLength(6)]
        public string BH { get; set; }

        [Required]
        [StringLength(32)]
        public string MBMC { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [Required]
        [StringLength(6)]
        public string DISP_ORDER { get; set; }

        [StringLength(1)]
        public string QYBZ { get; set; }
    }
}
