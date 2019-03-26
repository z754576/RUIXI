namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJZT_XJ_LOG")]
    public partial class TJ_TJZT_XJ_LOG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(14)]
        public string XJBH { get; set; }

        [StringLength(255)]
        public string ZDBH { get; set; }

        [StringLength(6)]
        public string ZHXMBH { get; set; }

        [StringLength(50)]
        public string JGQZ { get; set; }

        public bool? XJLX { get; set; }

        [StringLength(255)]
        public string XJTT { get; set; }

        public bool? CT { get; set; }

        public bool? ZDY { get; set; }

        public DateTime? XJRQ { get; set; }

        [StringLength(255)]
        public string JG { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        [StringLength(255)]
        public string XJSM { get; set; }

        [StringLength(4)]
        public string DISP_ORDER { get; set; }

        public int? DISP_ORDER1 { get; set; }
    }
}
