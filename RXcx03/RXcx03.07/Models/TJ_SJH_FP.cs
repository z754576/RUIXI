namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SJH_FP")]
    public partial class TJ_SJH_FP
    {
        [StringLength(15)]
        public string YLKH { get; set; }

        [StringLength(20)]
        public string FPQZ { get; set; }

        [Key]
        [StringLength(20)]
        public string FPXH { get; set; }

        [Required]
        [StringLength(20)]
        public string FPHM { get; set; }

        [StringLength(1)]
        public string SFTF { get; set; }

        public decimal? JE { get; set; }

        public int SJFPXH { get; set; }

        [StringLength(20)]
        public string SJH { get; set; }
    }
}
