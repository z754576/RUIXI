namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_FWHY")]
    public partial class TJ_FWHY
    {
        [Key]
        [StringLength(6)]
        public string BH { get; set; }

        [Required]
        [StringLength(40)]
        public string MC { get; set; }

        [StringLength(40)]
        public string YQRQ { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [Required]
        [StringLength(12)]
        public string ZHXGR { get; set; }
    }
}
