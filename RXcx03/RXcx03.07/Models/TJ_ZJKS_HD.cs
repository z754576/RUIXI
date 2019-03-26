namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZJKS_HD")]
    public partial class TJ_ZJKS_HD
    {
        [Key]
        [StringLength(6)]
        public string BH { get; set; }

        [StringLength(20)]
        public string MC { get; set; }

        [StringLength(8)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        [StringLength(4)]
        public string DISP_ORDER { get; set; }
    }
}
