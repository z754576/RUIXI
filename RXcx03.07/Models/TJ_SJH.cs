namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SJH")]
    public partial class TJ_SJH
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string SJH { get; set; }

        [StringLength(15)]
        public string YLKH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(6)]
        public string KB { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string BRSFLB { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string JSZL { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string EKJS { get; set; }

        [Key]
        [Column(Order = 5)]
        public double BRJSBL { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal ZJJE { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal ZFJE { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal JZJE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(1)]
        public string JSFS { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1)]
        public string DYBZ { get; set; }

        [Key]
        [Column(Order = 11)]
        public byte DYCS { get; set; }

        [StringLength(14)]
        public string YSSJH { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(1)]
        public string ZT { get; set; }

        [StringLength(32)]
        public string BZ { get; set; }

        public DateTime? JSRQ { get; set; }

        [StringLength(8)]
        public string SKY { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(6)]
        public string SKYBM { get; set; }

        [StringLength(8)]
        public string SFCRJID { get; set; }

        [StringLength(8)]
        public string RJID { get; set; }

        [StringLength(1)]
        public string RJBZ { get; set; }

        public DateTime? RJRQ { get; set; }

        [StringLength(6)]
        public string YS { get; set; }

        [StringLength(1)]
        public string YJBZ { get; set; }

        [StringLength(20)]
        public string JZBZ { get; set; }

        [StringLength(20)]
        public string JZDHM { get; set; }

        [StringLength(20)]
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

        [StringLength(1)]
        public string SFTF { get; set; }

        public decimal? XJJE { get; set; }

        public decimal? KJE { get; set; }

        [StringLength(12)]
        public string KJLH { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DJJE { get; set; }

        [StringLength(4)]
        public string ZKBH { get; set; }

        public decimal? TCZK { get; set; }

        public decimal? JZZK { get; set; }

        public decimal? ZEZK { get; set; }

        [Column(TypeName = "money")]
        public decimal? BCSS { get; set; }

        [Column(TypeName = "money")]
        public decimal? SSCE { get; set; }

        [Column(TypeName = "money")]
        public decimal? LJSS { get; set; }

        [Column(TypeName = "money")]
        public decimal? YSJE { get; set; }

        [Column(TypeName = "money")]
        public decimal? CZCE { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SJFPXH { get; set; }
    }
}
