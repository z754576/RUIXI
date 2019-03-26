namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_XGSFXM")]
    public partial class TJ_XGSFXM
    {
        [Key]
        [StringLength(2)]
        public string BH { get; set; }

        [Required]
        [StringLength(40)]
        public string MC { get; set; }

        public decimal? JG { get; set; }

        [StringLength(4)]
        public string SFLB { get; set; }

        [Required]
        [StringLength(1)]
        public string FLAG { get; set; }

        [StringLength(2)]
        public string DISP_ORDER { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
