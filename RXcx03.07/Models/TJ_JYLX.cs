namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JYLX")]
    public partial class TJ_JYLX
    {
        [Key]
        [StringLength(2)]
        public string BH { get; set; }

        [StringLength(20)]
        public string MC { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        public int? DISP_ORDER { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
