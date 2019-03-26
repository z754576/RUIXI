namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZHXM_HD")]
    public partial class TJ_ZHXM_HD
    {
        [Key]
        [StringLength(6)]
        public string BH { get; set; }

        [Required]
        [StringLength(32)]
        public string MC { get; set; }

        [Required]
        [StringLength(6)]
        public string TJLX { get; set; }

        [Required]
        [StringLength(1)]
        public string JCJYLX { get; set; }

        public bool? SFFK { get; set; }

        public decimal DJ { get; set; }

        public decimal? DZBL { get; set; }

        [StringLength(4)]
        public string SFLB { get; set; }

        [Required]
        [StringLength(1)]
        public string SFCX { get; set; }

        [StringLength(1)]
        public string SFXYBB { get; set; }

        [StringLength(2)]
        public string BBLX { get; set; }

        public int? BQDYFS { get; set; }

        [StringLength(255)]
        public string TSXX { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        [StringLength(1)]
        public string SFFCSQD { get; set; }

        [StringLength(4)]
        public string DYYJSB { get; set; }

        [StringLength(6)]
        public string DISP_ORDER { get; set; }

        [StringLength(6)]
        public string ZXKS { get; set; }

        [StringLength(1)]
        public string YXBZ { get; set; }

        [StringLength(1)]
        public string JGHQFS { get; set; }

        [StringLength(6)]
        public string PYJM { get; set; }

        [StringLength(6)]
        public string WBJM { get; set; }

        [StringLength(6)]
        public string ZDYM { get; set; }

        [StringLength(255)]
        public string ZCXJ { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        public decimal BZDJ { get; set; }

        [Required]
        [StringLength(1)]
        public string SFCQ { get; set; }

        [StringLength(255)]
        public string LCYY { get; set; }

        public int? PJJCSJ { get; set; }

        [StringLength(2)]
        public string LCLX { get; set; }

        public decimal? ZDZK { get; set; }

        public decimal? CBDJ { get; set; }

        [StringLength(255)]
        public string DJQZKS { get; set; }

        [StringLength(32)]
        public string SQD_JKBH { get; set; }

        [StringLength(32)]
        public string BGD_JKBH { get; set; }

        [StringLength(1)]
        public string SQDBH { get; set; }

        [StringLength(20)]
        public string GNLX { get; set; }

        [StringLength(1)]
        public string TPXSZT { get; set; }
    }
}
