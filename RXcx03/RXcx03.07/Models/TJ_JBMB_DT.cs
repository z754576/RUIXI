namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JBMB_DT")]
    public partial class TJ_JBMB_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string BH { get; set; }

        public int XH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string JBBH { get; set; }

        [Required]
        [StringLength(6)]
        public string TJLX { get; set; }
    }
}
