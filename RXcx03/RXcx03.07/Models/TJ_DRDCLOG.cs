namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DRDCLOG")]
    public partial class TJ_DRDCLOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string XTMC { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime SJ { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string SFCG { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string LX { get; set; }
    }
}
