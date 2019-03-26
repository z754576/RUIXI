namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.WJ_TJJLB")]
    public partial class WJ_TJJLB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        [Required]
        [StringLength(6)]
        public string LXBH { get; set; }

        [StringLength(3000)]
        public string XJ { get; set; }

        public DateTime? YDTJRQ { get; set; }

        public DateTime? JCRQ { get; set; }

        [StringLength(40)]
        public string JCYS { get; set; }

        [StringLength(6)]
        public string TJXMBH { get; set; }

        [Required]
        [StringLength(1)]
        public string XMLX { get; set; }

        public decimal XMDJ { get; set; }

        public decimal DZBL { get; set; }

        [Required]
        [StringLength(1)]
        public string ISOVER { get; set; }

        [Required]
        [StringLength(1)]
        public string JSFS { get; set; }

        [Required]
        [StringLength(1)]
        public string CHARGED { get; set; }

        [StringLength(6)]
        public string JSR { get; set; }

        public DateTime? JSRQ { get; set; }

        [StringLength(14)]
        public string SJH { get; set; }

        [StringLength(4)]
        public string SFLB { get; set; }

        [StringLength(40)]
        public string CZY { get; set; }

        public DateTime? CZSJ { get; set; }

        [StringLength(1)]
        public string SFJZ { get; set; }

        [StringLength(4)]
        public string DYYJSB { get; set; }

        [StringLength(6)]
        public string ZXKS { get; set; }

        [StringLength(8)]
        public string JYYS { get; set; }

        [StringLength(1)]
        public string SSLX { get; set; }

        [StringLength(6)]
        public string FZBH { get; set; }

        [StringLength(6)]
        public string TCBH { get; set; }

        [StringLength(1)]
        public string ZJBZ { get; set; }

        public decimal XMBL { get; set; }

        public decimal ZEBL { get; set; }

        public decimal SSDJ { get; set; }

        [StringLength(4000)]
        public string JCSJ { get; set; }

        [StringLength(1)]
        public string TPZT { get; set; }

        [StringLength(255)]
        public string TPLJ { get; set; }

        [StringLength(1000)]
        public string JCQKFZSM { get; set; }

        [Required]
        [StringLength(1)]
        public string SFZQ { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string JSJMC { get; set; }
    }
}
