namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_GZRY_ZHXM_OPENFACE")]
    public partial class TJ_GZRY_ZHXM_OPENFACE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string ZHXMBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string GZRYBH { get; set; }
    }
}
