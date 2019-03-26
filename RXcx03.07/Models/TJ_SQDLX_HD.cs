namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SQDLX_HD")]
    public partial class TJ_SQDLX_HD
    {
        [Key]
        [StringLength(6)]
        public string FLBH { get; set; }

        [Required]
        [StringLength(32)]
        public string FLMC { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [StringLength(6)]
        public string DISP_ORDER { get; set; }

        [StringLength(1)]
        public string QYBZ { get; set; }

        [StringLength(1)]
        public string JCJYLX { get; set; }

        [StringLength(2)]
        public string BBLX { get; set; }

        [StringLength(64)]
        public string TMQZ { get; set; }

        [StringLength(2)]
        public string FLAG { get; set; }

        [StringLength(4)]
        public string XH { get; set; }
    }
}
