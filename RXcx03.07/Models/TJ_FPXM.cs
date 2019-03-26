namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_FPXM")]
    public partial class TJ_FPXM
    {
        [Key]
        [StringLength(2)]
        public string BH { get; set; }

        [Required]
        [StringLength(32)]
        public string MC { get; set; }

        [StringLength(32)]
        public string BZ { get; set; }

        [StringLength(2)]
        public string DISP_ORDER { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        public bool? FLAG { get; set; }
    }
}
