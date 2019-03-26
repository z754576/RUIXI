namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJJL")]
    public partial class TJ_TJJL
    {
        [Key]
        [StringLength(3)]
        public string BH { get; set; }

        [StringLength(50)]
        public string MC { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        [StringLength(40)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
