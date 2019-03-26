namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SJH_LOG")]
    public partial class TJ_SJH_LOG
    {
        [Key]
        [StringLength(14)]
        public string SJH { get; set; }

        [StringLength(15)]
        public string YLKH { get; set; }

        [Required]
        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(6)]
        public string KB { get; set; }

        [Required]
        [StringLength(1)]
        public string BRSFLB { get; set; }

        [Required]
        [StringLength(1)]
        public string JSZL { get; set; }

        [Required]
        [StringLength(1)]
        public string EKJS { get; set; }

        public double BRJSBL { get; set; }

        [Column(TypeName = "money")]
        public decimal ZJJE { get; set; }

        [Column(TypeName = "money")]
        public decimal ZFJE { get; set; }

        [Column(TypeName = "money")]
        public decimal JZJE { get; set; }

        [Required]
        [StringLength(1)]
        public string JSFS { get; set; }

        [Required]
        [StringLength(1)]
        public string DYBZ { get; set; }

        public byte DYCS { get; set; }

        [StringLength(14)]
        public string YSSJH { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }

        [StringLength(32)]
        public string BZ { get; set; }

        public DateTime? JSRQ { get; set; }

        [StringLength(8)]
        public string SKY { get; set; }

        [Required]
        [StringLength(6)]
        public string SKYBM { get; set; }

        [StringLength(1)]
        public string RJBZ { get; set; }

        public DateTime? RJRQ { get; set; }

        [StringLength(6)]
        public string YS { get; set; }

        [StringLength(1)]
        public string YJBZ { get; set; }

        [StringLength(1)]
        public string JZBZ { get; set; }

        [StringLength(14)]
        public string JZDHM { get; set; }

        [StringLength(14)]
        public string JZDH { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZRJE { get; set; }

        [Column(TypeName = "money")]
        public decimal? TCZFJE { get; set; }

        [Column(TypeName = "money")]
        public decimal? GRZHZFJE { get; set; }

        [Column(TypeName = "money")]
        public decimal? YLJZZFJE { get; set; }

        [Column(TypeName = "money")]
        public decimal? TCJZJE { get; set; }

        [StringLength(1)]
        public string HPBZ { get; set; }

        public int? SFZL { get; set; }
    }
}
