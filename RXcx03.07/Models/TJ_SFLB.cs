namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SFLB")]
    public partial class TJ_SFLB
    {
        [Key]
        [StringLength(4)]
        public string BH { get; set; }

        [Required]
        [StringLength(32)]
        public string MC { get; set; }

        [StringLength(2)]
        public string HSLB { get; set; }

        [StringLength(10)]
        public string FPXM { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        [StringLength(4)]
        public string DISP_ORDER { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        [Required]
        [StringLength(1)]
        public string FLAG { get; set; }
    }
}
