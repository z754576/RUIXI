namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYTJ_WT")]
    public partial class TJ_ZYTJ_WT
    {
        [Key]
        [StringLength(4)]
        public string BH { get; set; }

        [Required]
        [StringLength(100)]
        public string MC { get; set; }

        [StringLength(2)]
        public string TZLX { get; set; }

        [StringLength(1)]
        public string TZLB { get; set; }

        [StringLength(1)]
        public string SFTS { get; set; }

        [StringLength(4)]
        public string DISP_ORDER { get; set; }

        [StringLength(1000)]
        public string BZ { get; set; }
    }
}
