namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SFD_LOG")]
    public partial class TJ_SFD_LOG
    {
        [StringLength(14)]
        public string SJH { get; set; }

        [StringLength(20)]
        public string YLKH { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(1)]
        public string BRJSLB { get; set; }

        [StringLength(14)]
        public string SFCK { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string LY { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string KDKS { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string SFLB { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(13)]
        public string SFBZBH { get; set; }

        [StringLength(32)]
        public string MC { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string DW { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal DJ { get; set; }

        [Key]
        [Column(Order = 7)]
        public double SL { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal SJFY { get; set; }

        public DateTime? RQ { get; set; }

        [StringLength(8)]
        public string SKY { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(6)]
        public string SKYBM { get; set; }

        [StringLength(6)]
        public string MZYS { get; set; }

        [StringLength(1)]
        public string TJBZ { get; set; }

        [StringLength(6)]
        public string ZXKS { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZRJE { get; set; }

        [StringLength(1)]
        public string LRFS { get; set; }

        [StringLength(1)]
        public string XMJCBZ { get; set; }

        [StringLength(6)]
        public string XMJCR { get; set; }

        public DateTime? XMJCRQ { get; set; }

        public DateTime? XMHDRQ { get; set; }

        [StringLength(6)]
        public string XMHDR { get; set; }
    }
}
