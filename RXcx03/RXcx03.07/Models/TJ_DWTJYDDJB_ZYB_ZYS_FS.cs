namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWTJYDDJB_ZYB_ZYS_FS")]
    public partial class TJ_DWTJYDDJB_ZYB_ZYS_FS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string DWBH { get; set; }

        [Required]
        [StringLength(16)]
        public string YYBH { get; set; }

        [Required]
        [StringLength(18)]
        public string SFZH { get; set; }

        public DateTime? QSRQ { get; set; }

        public DateTime? ZZRQ { get; set; }

        [StringLength(50)]
        public string GZDW { get; set; }

        [StringLength(32)]
        public string GZ { get; set; }

        [StringLength(64)]
        public string FSXZL { get; set; }

        [StringLength(64)]
        public string QD { get; set; }

        [StringLength(64)]
        public string LJSZJL { get; set; }

        [StringLength(64)]
        public string YCSZSQK { get; set; }

        [StringLength(64)]
        public string JTFY { get; set; }

        public bool? ISNew { get; set; }

        [StringLength(40)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
