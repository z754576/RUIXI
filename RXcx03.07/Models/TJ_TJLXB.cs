namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJLXB")]
    public partial class TJ_TJLXB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string LXBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string MC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string XSLX { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string JCJYLX { get; set; }

        [StringLength(255)]
        public string KSXX { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        [StringLength(4)]
        public string DISP_ORDER { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string TSFH { get; set; }

        public int? DJSX { get; set; }

        [StringLength(2)]
        public string HZKS { get; set; }

        [Column(TypeName = "image")]
        public byte[] CTP { get; set; }

        [Column(TypeName = "image")]
        public byte[] BTP { get; set; }
    }
}
