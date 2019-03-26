namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SFD")]
    public partial class TJ_SFD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string SJH { get; set; }

        [StringLength(15)]
        public string YLKH { get; set; }

        [Required]
        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(1)]
        public string BRJSLB { get; set; }

        [StringLength(14)]
        public string SFCK { get; set; }

        [Required]
        [StringLength(2)]
        public string LY { get; set; }

        [Required]
        [StringLength(6)]
        public string KDKS { get; set; }

        [Required]
        [StringLength(4)]
        public string SFLB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(13)]
        public string SFBZBH { get; set; }

        [StringLength(32)]
        public string MC { get; set; }

        [Required]
        [StringLength(10)]
        public string DW { get; set; }

        [Column(TypeName = "money")]
        public decimal DJ { get; set; }

        public double SL { get; set; }

        [Column(TypeName = "money")]
        public decimal SJFY { get; set; }

        public DateTime? RQ { get; set; }

        [StringLength(8)]
        public string SKY { get; set; }

        [Required]
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

        [StringLength(1)]
        public string SSLX { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string FZBH { get; set; }

        [StringLength(6)]
        public string TCBH { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string SFTF { get; set; }

        public decimal? ZKBL { get; set; }

        public decimal? YSDJ { get; set; }
    }
}
