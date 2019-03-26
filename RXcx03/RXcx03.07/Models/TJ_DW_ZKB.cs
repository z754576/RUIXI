namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DW_ZKB")]
    public partial class TJ_DW_ZKB
    {
        [Key]
        [StringLength(15)]
        public string DJBH { get; set; }

        [Required]
        [StringLength(10)]
        public string DWBH { get; set; }

        public int? TJCS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DJ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal YSJE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal YSJE2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ZKJE { get; set; }

        [Required]
        [StringLength(10)]
        public string SKR { get; set; }

        public DateTime SKRQ { get; set; }
    }
}
