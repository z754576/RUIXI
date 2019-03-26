namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KJL_XMB")]
    public partial class TJ_KJL_XMB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string TJXM { get; set; }
    }
}
