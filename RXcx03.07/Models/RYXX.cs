namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.RYXX")]
    public partial class RYXX
    {
        [Key]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int? TJCS { get; set; }

        [Required]
        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        [StringLength(18)]
        public string SFZH { get; set; }

        public DateTime? CSNYR { get; set; }

        [StringLength(10)]
        public string TITLE { get; set; }

        [StringLength(10)]
        public string ZC { get; set; }

        public DateTime? REG_DATE { get; set; }

        [StringLength(6)]
        public string YEARMONTH { get; set; }

        [StringLength(5)]
        public string MARYYIED { get; set; }

        [StringLength(30)]
        public string NATIVE { get; set; }

        [StringLength(20)]
        public string JOB { get; set; }

        [StringLength(100)]
        public string PHONE { get; set; }

        [StringLength(100)]
        public string ADDRESS { get; set; }

        [StringLength(255)]
        public string ILL { get; set; }

        [StringLength(6)]
        public string ILL_CODE { get; set; }

        [StringLength(4)]
        public string COMPANY { get; set; }

        [StringLength(100)]
        public string SICK { get; set; }

        [StringLength(6)]
        public string SICK_CODE { get; set; }

        [StringLength(20)]
        public string BRAIN_JOB { get; set; }

        [StringLength(20)]
        public string SLEEP { get; set; }

        [StringLength(20)]
        public string EAT { get; set; }

        [StringLength(100)]
        public string OPERATION { get; set; }

        [StringLength(255)]
        public string FAMILY_ILL { get; set; }

        [StringLength(20)]
        public string THEW_JOB { get; set; }

        [StringLength(20)]
        public string TJMC { get; set; }

        [StringLength(10)]
        public string NATION { get; set; }

        [StringLength(2)]
        public string LABEL { get; set; }

        public int? VALID { get; set; }

        public int? MAXCHID { get; set; }

        [StringLength(20)]
        public string DEPT { get; set; }

        [StringLength(8)]
        public string CHOSTID { get; set; }

        public DateTime? DEND { get; set; }

        [StringLength(20)]
        public string SMOKE { get; set; }

        [StringLength(20)]
        public string WINE { get; set; }

        [StringLength(20)]
        public string COFFEE { get; set; }

        [StringLength(20)]
        public string TEA { get; set; }

        [StringLength(100)]
        public string CUR_ILL { get; set; }

        [StringLength(255)]
        public string WAISHANG { get; set; }

        [StringLength(10)]
        public string ZHXGR { get; set; }

        [StringLength(50)]
        public string ZY { get; set; }

        [StringLength(200)]
        public string YWGMS { get; set; }

        [StringLength(2)]
        public string BLOOD { get; set; }

        [StringLength(20)]
        public string SPORT { get; set; }

        [StringLength(20)]
        public string QTXG { get; set; }

        [StringLength(2)]
        public string XYSJ { get; set; }

        public DateTime? ZHXGSJ { get; set; }

        [StringLength(2)]
        public string XYSL { get; set; }

        [StringLength(50)]
        public string MZ { get; set; }
    }
}
