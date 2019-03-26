namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_RYXX")]
    public partial class TJ_ZYB_RYXX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [Required]
        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        [StringLength(18)]
        public string SFZH { get; set; }

        public DateTime? CSNYR { get; set; }

        [StringLength(50)]
        public string DW { get; set; }

        [StringLength(50)]
        public string DWDH { get; set; }

        [StringLength(18)]
        public string GH { get; set; }

        [StringLength(18)]
        public string BH { get; set; }

        public DateTime? TBRQ { get; set; }

        [StringLength(1)]
        public string LX { get; set; }

        [StringLength(100)]
        public string JWS { get; set; }

        [StringLength(30)]
        public string BM { get; set; }

        public DateTime? ZDRQ { get; set; }

        [StringLength(50)]
        public string ZDDW { get; set; }

        [StringLength(30)]
        public string SFQY { get; set; }

        public int? CCNL { get; set; }

        public int? JQ { get; set; }

        public int? ZQ { get; set; }

        public int? TJNL { get; set; }

        public int? XYZN { get; set; }

        public int? LCCS { get; set; }

        public int? ZCCS { get; set; }

        public int? SCCS { get; set; }

        public int? YCTC { get; set; }

        [StringLength(1)]
        public string SFXY { get; set; }

        public int? XYSL { get; set; }

        [StringLength(20)]
        public string XYNS { get; set; }

        [StringLength(1)]
        public string SFYJ { get; set; }

        public int? YJSL { get; set; }

        [StringLength(20)]
        public string YJSJ { get; set; }

        [StringLength(100)]
        public string QT { get; set; }

        public int? FSGL { get; set; }

        [StringLength(10)]
        public string FSGZ { get; set; }

        [StringLength(10)]
        public string FSYZL { get; set; }

        [StringLength(10)]
        public string FSQD { get; set; }

        [StringLength(10)]
        public string SZJL { get; set; }

        [StringLength(24)]
        public string YCQK { get; set; }

        [StringLength(24)]
        public string JTFY { get; set; }

        [StringLength(255)]
        public string DHQK { get; set; }

        [StringLength(200)]
        public string JTBS { get; set; }

        [StringLength(50)]
        public string DWDZ { get; set; }

        [StringLength(30)]
        public string GZ { get; set; }

        [StringLength(50)]
        public string YGZDWJGZ { get; set; }

        [StringLength(50)]
        public string ZYBWHJCS { get; set; }

        [StringLength(100)]
        public string CSD { get; set; }

        [StringLength(10)]
        public string MZ { get; set; }

        [StringLength(50)]
        public string HY { get; set; }

        [StringLength(20)]
        public string JSGL { get; set; }

        [StringLength(20)]
        public string ZGL { get; set; }

        [StringLength(100)]
        public string LCBX { get; set; }

        [StringLength(200)]
        public string XYSJCJG { get; set; }

        [StringLength(50)]
        public string ZDBZ { get; set; }

        [StringLength(500)]
        public string ZDJL { get; set; }

        [StringLength(500)]
        public string CLYJ { get; set; }

        [StringLength(50)]
        public string WJH { get; set; }

        [StringLength(50)]
        public string ZDBZ2 { get; set; }

        [StringLength(50)]
        public string ZDBZ3 { get; set; }

        [StringLength(100)]
        public string ZYJCS { get; set; }

        [StringLength(50)]
        public string JTDZ { get; set; }

        [StringLength(30)]
        public string WHCD { get; set; }

        [StringLength(100)]
        public string HXXT { get; set; }

        [StringLength(100)]
        public string XHXT { get; set; }

        [StringLength(100)]
        public string XHUAXT { get; set; }

        [StringLength(100)]
        public string ZXXT { get; set; }

        [StringLength(100)]
        public string NFMXT { get; set; }

        [StringLength(100)]
        public string MLSZXT { get; set; }

        [StringLength(100)]
        public string PF { get; set; }

        public DateTime? JHRQ { get; set; }

        [StringLength(100)]
        public string POJCFSXQK { get; set; }

        [StringLength(100)]
        public string POZYJJKZK { get; set; }

        public int? YC { get; set; }

        public int? HCNAN { get; set; }

        public int? HCNV { get; set; }

        public int? DTC { get; set; }

        public int? JTC { get; set; }

        [StringLength(100)]
        public string ZNJKZK { get; set; }

        [StringLength(200)]
        public string XHBJZYZZ { get; set; }

        [StringLength(100)]
        public string BYYYY { get; set; }

        [StringLength(1)]
        public string PJ_WJYC { get; set; }

        [StringLength(1)]
        public string PJ_FC { get; set; }

        [StringLength(1)]
        public string PJ_YSZYB { get; set; }

        [StringLength(1)]
        public string PJ_ZYJJZ { get; set; }

        [StringLength(1)]
        public string PJ_QTYC { get; set; }

        [StringLength(1000)]
        public string ZZ { get; set; }

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

        [StringLength(200)]
        public string CJ { get; set; }
    }
}
