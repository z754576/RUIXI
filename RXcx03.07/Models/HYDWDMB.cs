namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.HYDWDMB")]
    public partial class HYDWDMB
    {
        [Key]
        [StringLength(25)]
        public string BH { get; set; }

        [Required]
        [StringLength(64)]
        public string MC { get; set; }

        [StringLength(13)]
        public string SJDWBH { get; set; }

        [StringLength(255)]
        public string DWFZR { get; set; }

        [StringLength(255)]
        public string LXDH { get; set; }

        [StringLength(16)]
        public string CZDH { get; set; }

        [StringLength(255)]
        public string LXDZ { get; set; }

        [StringLength(6)]
        public string YZBM { get; set; }

        [StringLength(1)]
        public string QYXZ { get; set; }

        [StringLength(6)]
        public string YWYY { get; set; }

        [StringLength(20)]
        public string YHZH { get; set; }

        public int? JZRS { get; set; }

        public double? LJZFJE { get; set; }

        public double? LJZCJE { get; set; }

        [StringLength(32)]
        public string BZ { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        [StringLength(2)]
        public string LB { get; set; }

        public int? BZRS { get; set; }

        [StringLength(10)]
        public string PYJM { get; set; }

        [StringLength(10)]
        public string WBJM { get; set; }

        [StringLength(1)]
        public string JZBZ { get; set; }

        [StringLength(20)]
        public string JC { get; set; }

        [StringLength(1)]
        public string SFBZ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? YFJE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WFJE { get; set; }

        [StringLength(50)]
        public string KHBH { get; set; }

        [StringLength(100)]
        public string ZZJGDM { get; set; }

        [StringLength(100)]
        public string QYGM { get; set; }

        [StringLength(100)]
        public string JJLX { get; set; }

        [StringLength(100)]
        public string HYFL { get; set; }

        public int? ZGRS { get; set; }

        public int? NZGRS { get; set; }

        public int? SCGRS { get; set; }

        public int? NSCGRS { get; set; }

        public int? JHRS { get; set; }

        public int? NJHRS { get; set; }

        [StringLength(8000)]
        public string GYLC { get; set; }

        [StringLength(8000)]
        public string DWJJ { get; set; }
    }
}
