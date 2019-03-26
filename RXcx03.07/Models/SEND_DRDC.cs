namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SEND_DRDC")]
    public partial class SEND_DRDC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string BH { get; set; }

        [Required]
        [StringLength(1)]
        public string DRDCBZ { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string LY { get; set; }

        [StringLength(10)]
        public string CZY { get; set; }

        public DateTime CZSJ { get; set; }
    }
}
