namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_FP_CZY")]
    public partial class TJ_FP_CZY
    {
        [Key]
        public int BH { get; set; }

        [Required]
        [StringLength(10)]
        public string CZYBH { get; set; }

        [StringLength(20)]
        public string FPQZ { get; set; }

        [Required]
        [StringLength(10)]
        public string FPQSH { get; set; }

        [Required]
        [StringLength(10)]
        public string FPZZH { get; set; }

        public DateTime? FFRQ { get; set; }

        [StringLength(20)]
        public string QT { get; set; }
    }
}
