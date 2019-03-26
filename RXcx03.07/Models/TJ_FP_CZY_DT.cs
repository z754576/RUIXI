namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_FP_CZY_DT")]
    public partial class TJ_FP_CZY_DT
    {
        [Key]
        public int BH { get; set; }

        [Required]
        [StringLength(10)]
        public string CZYBH { get; set; }

        [Required]
        [StringLength(30)]
        public string FPBH { get; set; }

        [Required]
        [StringLength(1)]
        public string FPZT { get; set; }

        [StringLength(20)]
        public string FPHM { get; set; }

        [StringLength(20)]
        public string FPQZ { get; set; }
    }
}
