namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TOPZD")]
    public partial class TJ_TOPZD
    {
        public int ID { get; set; }

        [Required]
        [StringLength(6)]
        public string LXBH { get; set; }

        [Required]
        [StringLength(6)]
        public string BH { get; set; }

        [StringLength(64)]
        public string MC { get; set; }

        public int? CS { get; set; }
    }
}
