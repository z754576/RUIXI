namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJZTB_DT")]
    public partial class TJ_TJZTB_DT
    {
        [Required]
        [StringLength(6)]
        public string QYBH { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string ZTBH { get; set; }

        [Required]
        [StringLength(6)]
        public string TJLX { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ZHXMBH { get; set; }

        public int XH { get; set; }
    }
}
