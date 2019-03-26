namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWTJYDDJB_ZYB")]
    public partial class TJ_DWTJYDDJB_ZYB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string DWBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(16)]
        public string YYBH { get; set; }

        [StringLength(30)]
        public string GZ { get; set; }

        public int? ZGL { get; set; }

        public int? JHGL { get; set; }

        [StringLength(200)]
        public string DHZL { get; set; }

        public int? YJS_CC { get; set; }

        public int? YJS_JQ { get; set; }

        public int? YJS_ZQ { get; set; }

        public int? YJS_TJNL { get; set; }

        public int? SYS_XYZV { get; set; }

        public int? SYS_LC { get; set; }

        public int? SYS_ZC { get; set; }

        public int? SYS_SC { get; set; }

        public int? SYS_YCT { get; set; }

        public int? YJS_XYGL { get; set; }

        public int? YJS_XYSL { get; set; }

        public int? YJS_XYNL { get; set; }

        public int? YJS_YJGL { get; set; }

        public int? YJS_YJSL { get; set; }

        public int? YJS_YJNL { get; set; }

        [StringLength(1000)]
        public string JWS { get; set; }

        [StringLength(1000)]
        public string ZZ { get; set; }

        [StringLength(30)]
        public string BM { get; set; }

        public DateTime? ZDRQ { get; set; }

        [StringLength(30)]
        public string ZDDW { get; set; }

        [StringLength(30)]
        public string SFQY { get; set; }

        [StringLength(6)]
        public string YZBM { get; set; }

        public int? YWRCCS { get; set; }

        [StringLength(100)]
        public string BoyBirthday { get; set; }

        [StringLength(100)]
        public string GirlBirthday { get; set; }

        public int? JYNS { get; set; }

        [StringLength(200)]
        public string HYSBZ { get; set; }

        [StringLength(200)]
        public string SYSBZ { get; set; }

        public int? HCCS { get; set; }

        public int? YC { get; set; }

        public int? DTCS { get; set; }

        [StringLength(100)]
        public string BYYYY { get; set; }

        public int? XYboy { get; set; }

        public int? XYgirl { get; set; }

        [StringLength(100)]
        public string ZNJKQK { get; set; }

        [StringLength(100)]
        public string SHSBZ { get; set; }

        [StringLength(100)]
        public string JZS { get; set; }

        [StringLength(10)]
        public string WHCD { get; set; }

        [StringLength(100)]
        public string CSD { get; set; }

        public DateTime? JHRQ { get; set; }

        [StringLength(100)]
        public string POJCFSXQK { get; set; }

        [StringLength(200)]
        public string CJ { get; set; }
    }
}
