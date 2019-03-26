namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.GZRY")]
    public partial class GZRY
    {
        [Key]
        [StringLength(6)]
        public string GKHM { get; set; }

        [StringLength(8)]
        public string DYSRM { get; set; }

        [StringLength(8)]
        public string DESRM { get; set; }

        [StringLength(6)]
        public string GKMM { get; set; }

        [StringLength(10)]
        public string PYJM { get; set; }

        [StringLength(4)]
        public string WBJM { get; set; }

        [StringLength(10)]
        public string QTSRF { get; set; }

        [Required]
        [StringLength(40)]
        public string XM { get; set; }

        public DateTime? CSRQ { get; set; }

        [StringLength(15)]
        public string SFZHM { get; set; }

        [StringLength(1)]
        public string CX { get; set; }

        [StringLength(30)]
        public string QX { get; set; }

        [StringLength(4)]
        public string ZW { get; set; }

        [StringLength(10)]
        public string ZC { get; set; }

        [StringLength(6)]
        public string GZKS { get; set; }

        [StringLength(2)]
        public string GZBQ { get; set; }

        [StringLength(40)]
        public string GZDZ { get; set; }

        [StringLength(15)]
        public string BGSDH { get; set; }

        [StringLength(30)]
        public string ZZ { get; set; }

        [StringLength(15)]
        public string ZZDH { get; set; }

        [StringLength(20)]
        public string CHHM { get; set; }

        [Required]
        [StringLength(1)]
        public string SRF { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [Required]
        [StringLength(8)]
        public string ZHXGR { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        [StringLength(1)]
        public string JB { get; set; }

        [StringLength(1)]
        public string DYZYD { get; set; }

        [StringLength(1)]
        public string DYBQ { get; set; }

        [Required]
        [StringLength(1)]
        public string LX { get; set; }

        [StringLength(1)]
        public string CAN_DEFINED_DATAWINDOW { get; set; }

        [StringLength(2)]
        public string DEFAULT_MODE { get; set; }

        public int? DYJCSQD { get; set; }

        [StringLength(1)]
        public string ZJYS { get; set; }

        [Required]
        [StringLength(1)]
        public string ADDZD { get; set; }

        [StringLength(1000)]
        public string YSJJ { get; set; }

        [StringLength(6)]
        public string ZTBH { get; set; }
    }
}
