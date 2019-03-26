namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KLB_XMB")]
    public partial class TJ_KLB_XMB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string LBBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string TJXM { get; set; }

        public int CS { get; set; }
    }
}
