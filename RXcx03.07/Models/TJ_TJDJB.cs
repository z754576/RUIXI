namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJDJB")]
    public partial class TJ_TJDJB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        public int? DWTJCS { get; set; }

        [StringLength(14)]
        public string RYBH { get; set; }

        [Required]
        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        public DateTime? CSNYR { get; set; }

        public int? NL { get; set; }

        [StringLength(25)]
        public string DWBH { get; set; }

        public DateTime TJRQ { get; set; }

        public DateTime DJRQ { get; set; }

        [Required]
        [StringLength(6)]
        public string DJRY { get; set; }

        [Column(TypeName = "text")]
        public string ZS { get; set; }

        [Column(TypeName = "text")]
        public string JY { get; set; }

        public DateTime? JCRQ { get; set; }

        [StringLength(6)]
        public string JCYS { get; set; }

        public DateTime? GDRQ { get; set; }

        [StringLength(6)]
        public string GDYS { get; set; }

        [StringLength(18)]
        public string SFZH { get; set; }

        [StringLength(16)]
        public string ZC { get; set; }

        [StringLength(16)]
        public string ZW { get; set; }

        [StringLength(2)]
        public string TJLB { get; set; }

        [StringLength(2)]
        public string RYLB { get; set; }

        [StringLength(1)]
        public string HYZK { get; set; }

        [StringLength(1)]
        public string FZFS { get; set; }

        [StringLength(6)]
        public string FZBH { get; set; }

        [Required]
        [StringLength(1)]
        public string JSFS { get; set; }

        [StringLength(16)]
        public string YYBH { get; set; }

        [Required]
        [StringLength(1)]
        public string SUMOVER { get; set; }

        [StringLength(64)]
        public string DEPART { get; set; }

        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(128)]
        public string ADDRESS { get; set; }

        [StringLength(32)]
        public string PHONE { get; set; }

        [StringLength(50)]
        public string BMBH { get; set; }

        [StringLength(12)]
        public string SJCXXH { get; set; }

        public int? DYCS { get; set; }

        public DateTime? DYRQ { get; set; }

        public DateTime? FZTZRQ { get; set; }

        [StringLength(6)]
        public string FZTZYS { get; set; }

        [StringLength(255)]
        public string FZBZ { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(3)]
        public string TJJL { get; set; }

        [StringLength(20)]
        public string RSDAH { get; set; }

        [Required]
        [StringLength(6)]
        public string CZY { get; set; }

        [Required]
        [StringLength(1)]
        public string SFBZ { get; set; }

        [StringLength(40)]
        public string TJJSR { get; set; }

        public int? YF { get; set; }

        [StringLength(15)]
        public string MOBILE { get; set; }

        [StringLength(1)]
        public string SV_CALLBACK { get; set; }

        [StringLength(1)]
        public string SV_SMS { get; set; }

        [StringLength(1)]
        public string SV_EMAIL { get; set; }

        [StringLength(1)]
        public string SV_WEB { get; set; }

        public DateTime? GZRQ { get; set; }

        [StringLength(4)]
        public string JCSJ { get; set; }

        [StringLength(32)]
        public string BM { get; set; }

        [StringLength(10)]
        public string GZ { get; set; }

        [StringLength(24)]
        public string YHYS { get; set; }

        [StringLength(1)]
        public string WHCD { get; set; }

        [StringLength(1)]
        public string TJBZ { get; set; }

        public DateTime? FZRQ { get; set; }

        [StringLength(40)]
        public string FZDW { get; set; }

        [Column(TypeName = "image")]
        public byte[] PICTURE { get; set; }

        [StringLength(12)]
        public string BZR { get; set; }

        [StringLength(20)]
        public string SYKH { get; set; }

        [StringLength(2)]
        public string TJSFZC { get; set; }

        [Column(TypeName = "text")]
        public string KBSM { get; set; }

        [StringLength(25)]
        public string HYID { get; set; }

        [StringLength(1)]
        public string SFKD { get; set; }

        [StringLength(255)]
        public string GRZPBCLJ { get; set; }

        [StringLength(50)]
        public string ZDYJ { get; set; }

        [Required]
        [StringLength(2)]
        public string TJYWLX { get; set; }

        [StringLength(50)]
        public string MZ { get; set; }

        [StringLength(6)]
        public string DJDLH { get; set; }

        [StringLength(1)]
        public string SFVIP { get; set; }

        [StringLength(6)]
        public string YSBH { get; set; }

        [StringLength(1)]
        public string ZYDHSBZ { get; set; }

        [StringLength(6)]
        public string ZYDHSR { get; set; }

        public DateTime? ZYDHSRQ { get; set; }

        [StringLength(1)]
        public string TJBGFFBZ { get; set; }

        public DateTime? TJBGFFRQ { get; set; }

        [StringLength(6)]
        public string TJBGFFR { get; set; }

        [StringLength(14)]
        public string SJH { get; set; }

        [StringLength(1)]
        public string DWTJGRSFBZ { get; set; }

        public int? ZYDDYCS { get; set; }

        [StringLength(60)]
        public string BZ { get; set; }

        [StringLength(1)]
        public string LIS_SQBZ { get; set; }

        [StringLength(1)]
        public string PACS_SQBZ { get; set; }

        [StringLength(1)]
        public string RIS_SQBZ { get; set; }

        public int? DAYS { get; set; }

        [StringLength(255)]
        public string PARENTSNAMES { get; set; }

        [StringLength(255)]
        public string ClASS { get; set; }

        public int FCBS { get; set; }

        public int? FCHZZT { get; set; }

        [StringLength(25)]
        public string BS { get; set; }

        public int? Bidentify { get; set; }

        public int? FWJG { get; set; }

        [StringLength(10)]
        public string SBBH { get; set; }
    }
}
