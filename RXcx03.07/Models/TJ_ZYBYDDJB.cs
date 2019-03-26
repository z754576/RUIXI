namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYBYDDJB")]
    public partial class TJ_ZYBYDDJB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(18)]
        public string SFZH { get; set; }

        [StringLength(100)]
        public string DWMC { get; set; }

        [StringLength(25)]
        public string DWBH { get; set; }

        [StringLength(100)]
        public string BMMC { get; set; }

        [StringLength(18)]
        public string BMBH { get; set; }

        [StringLength(14)]
        public string RYBH { get; set; }

        [StringLength(50)]
        public string FZMC { get; set; }

        [StringLength(7)]
        public string FZBH { get; set; }

        public int? BQGS { get; set; }

        [StringLength(30)]
        public string GWGZ { get; set; }

        [Required]
        [StringLength(40)]
        public string MC { get; set; }

        [Required]
        [StringLength(1)]
        public string XB { get; set; }

        public int? NL { get; set; }

        [StringLength(20)]
        public string TJLB { get; set; }

        [StringLength(32)]
        public string SJH { get; set; }

        [StringLength(10)]
        public string HYZK { get; set; }

        [StringLength(30)]
        public string GZ { get; set; }

        [StringLength(20)]
        public string ZGL { get; set; }

        [StringLength(20)]
        public string JHGL { get; set; }

        [StringLength(64)]
        public string DHZL { get; set; }

        [StringLength(3)]
        public string YJS_CC { get; set; }

        [StringLength(3)]
        public string YJS_JQ { get; set; }

        [StringLength(3)]
        public string YJS_ZQ { get; set; }

        [StringLength(3)]
        public string YJS_TJNL { get; set; }

        [StringLength(3)]
        public string SYS_XYZV { get; set; }

        [StringLength(3)]
        public string SYS_LC { get; set; }

        [StringLength(3)]
        public string SYS_ZC { get; set; }

        [StringLength(3)]
        public string SYS_SC { get; set; }

        [StringLength(3)]
        public string SYS_YCT { get; set; }

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

        public bool ISNew { get; set; }

        [Required]
        [StringLength(20)]
        public string ClientIP { get; set; }

        [Required]
        [StringLength(40)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [StringLength(15)]
        public string LXDH { get; set; }

        [StringLength(16)]
        public string ZC { get; set; }

        [StringLength(16)]
        public string ZW { get; set; }

        [StringLength(2)]
        public string RYLB { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public bool? SFVIP { get; set; }

        public DateTime? DJRQ { get; set; }

        [StringLength(50)]
        public string TJJSR { get; set; }

        [StringLength(50)]
        public string JSFS { get; set; }

        [StringLength(50)]
        public string MZ { get; set; }

        [StringLength(20)]
        public string SYKH { get; set; }

        public DateTime? CSNYR { get; set; }

        [StringLength(30)]
        public string BM { get; set; }

        public DateTime? ZDRQ { get; set; }

        [StringLength(30)]
        public string ZDDW { get; set; }

        [StringLength(30)]
        public string SFQY { get; set; }

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

        [StringLength(6)]
        public string YZBM { get; set; }

        [StringLength(200)]
        public string CJ { get; set; }
    }
}
