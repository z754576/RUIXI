namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JWBS")]
    public partial class TJ_JWBS
    {
        [Key]
        [StringLength(14)]
        public string TJH { get; set; }

        [Required]
        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        [StringLength(18)]
        public string SFZH { get; set; }

        [StringLength(16)]
        public string JOB { get; set; }

        [StringLength(64)]
        public string JG { get; set; }

        [StringLength(64)]
        public string ADDRESS { get; set; }

        [StringLength(12)]
        public string PHONE { get; set; }

        [StringLength(255)]
        public string JWBS { get; set; }

        [StringLength(255)]
        public string YWGMS { get; set; }

        [StringLength(255)]
        public string ZLZK { get; set; }

        [StringLength(255)]
        public string MQHZBS { get; set; }

        [StringLength(1)]
        public string GZQD_NL { get; set; }

        [StringLength(1)]
        public string GZQD_TL { get; set; }

        [StringLength(1)]
        public string SMZK { get; set; }

        [StringLength(1)]
        public string SMZK_SM { get; set; }

        [StringLength(1)]
        public string YYZK { get; set; }

        public int? SMOKE_DAY { get; set; }

        public int? SMOKE_YEAR { get; set; }

        [StringLength(1)]
        public string WINE { get; set; }

        [StringLength(1)]
        public string COFFEE { get; set; }

        [StringLength(1)]
        public string TEA { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }
    }
}
