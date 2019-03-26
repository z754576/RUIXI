namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KLB_HD")]
    public partial class TJ_KLB_HD
    {
        [Key]
        [StringLength(4)]
        public string BH { get; set; }

        [Required]
        [StringLength(30)]
        public string MC { get; set; }

        [StringLength(4)]
        public string DISP_ORDER { get; set; }

        public decimal XSJE { get; set; }

        public DateTime? YXRQ { get; set; }

        public int? YXSYCS { get; set; }

        [StringLength(200)]
        public string BZ { get; set; }

        [StringLength(6)]
        public string CZY { get; set; }

        public DateTime? CZSJ { get; set; }
    }
}
