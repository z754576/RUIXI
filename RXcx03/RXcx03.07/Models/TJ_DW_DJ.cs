namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DW_DJ")]
    public partial class TJ_DW_DJ
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

        [Required]
        [StringLength(1)]
        public string DJZT { get; set; }

        [Required]
        [StringLength(10)]
        public string CZYBH { get; set; }

        public DateTime RQ { get; set; }

        [StringLength(15)]
        public string YSPZ { get; set; }

        [StringLength(10)]
        public string RJID { get; set; }
    }
}
