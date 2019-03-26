namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.GGWS_TJZM")]
    public partial class GGWS_TJZM
    {
        [StringLength(8)]
        public string BH { get; set; }

        [Key]
        [StringLength(8)]
        public string JKZBH { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int? TJCS { get; set; }

        [Required]
        [StringLength(40)]
        public string XM { get; set; }

        public int NL { get; set; }

        [StringLength(20)]
        public string GZ { get; set; }

        [Required]
        [StringLength(1)]
        public string TJJG { get; set; }

        public DateTime? FZRQ { get; set; }

        [StringLength(40)]
        public string JKTJDW { get; set; }

        [StringLength(50)]
        public string YXQ { get; set; }

        [StringLength(20)]
        public string HY { get; set; }

        [Required]
        [StringLength(1)]
        public string XB { get; set; }

        [StringLength(40)]
        public string FWDW { get; set; }

        public DateTime? TJRQ { get; set; }

        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(40)]
        public string BZR { get; set; }

        [StringLength(20)]
        public string BMZJHM { get; set; }
    }
}
