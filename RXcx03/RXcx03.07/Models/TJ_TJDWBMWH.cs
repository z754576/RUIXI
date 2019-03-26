namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJDWBMWH")]
    public partial class TJ_TJDWBMWH
    {
        [Required]
        [StringLength(25)]
        public string DWBH { get; set; }

        [StringLength(50)]
        public string SJBMBH { get; set; }

        [Key]
        [StringLength(50)]
        public string BMBH { get; set; }

        [Required]
        [StringLength(32)]
        public string BMMC { get; set; }

        [StringLength(16)]
        public string BMFZR { get; set; }

        [StringLength(24)]
        public string BMLXDH { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        [StringLength(12)]
        public string DISP_ORDER { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
