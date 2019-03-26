namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJDJB_JKB")]
    public partial class TJ_TJDJB_JKB
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string UniqueID { get; set; }

        [StringLength(50)]
        public string XM { get; set; }

        [StringLength(5)]
        public string XB { get; set; }

        public int? NL { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        public int? TJCS { get; set; }

        [StringLength(12)]
        public string TJBH { get; set; }

        public int? TJBQ { get; set; }

        public DateTime? CSNYR { get; set; }

        [StringLength(20)]
        public string SFZH { get; set; }

        [StringLength(20)]
        public string YWLXBH { get; set; }

        public int? HYZK { get; set; }

        public DateTime? TJRQ { get; set; }

        [StringLength(30)]
        public string YYDW { get; set; }

        [StringLength(20)]
        public string YGGH { get; set; }

        [StringLength(200)]
        public string JTZZ { get; set; }

        [StringLength(200)]
        public string TJTCMC { get; set; }

        public decimal? TCZJ { get; set; }

        [StringLength(50)]
        public string YYM { get; set; }

        public int? SFZF { get; set; }

        public int? SFDJ { get; set; }

        public DateTime? CJSJ { get; set; }

        [StringLength(20)]
        public string CJR { get; set; }

        public DateTime? XGSJ { get; set; }

        [StringLength(20)]
        public string XGR { get; set; }

        public decimal? SSHJ { get; set; }
    }
}
