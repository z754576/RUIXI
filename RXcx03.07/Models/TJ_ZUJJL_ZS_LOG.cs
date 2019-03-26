namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZUJJL_ZS_LOG")]
    public partial class TJ_ZUJJL_ZS_LOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(14)]
        public string BH { get; set; }

        [StringLength(1024)]
        public string JG { get; set; }

        [StringLength(255)]
        public string ZDBH { get; set; }

        [StringLength(6)]
        public string ZHXMBH { get; set; }

        [StringLength(50)]
        public string JGQZ { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string ZUJKS { get; set; }

        [StringLength(6)]
        public string LXBH { get; set; }

        public bool? ZUJLX { get; set; }

        [StringLength(255)]
        public string ZJTT { get; set; }

        public bool? CT { get; set; }

        public bool? ZDY { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        public int? DISP_ORDER { get; set; }

        public int? DISP_ORDER1 { get; set; }

        public int? DISP_ORDER2 { get; set; }

        public int? DISP_ORDER3 { get; set; }
    }
}
