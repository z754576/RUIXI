namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_HSB_ZDY_HD")]
    public partial class TJ_HSB_ZDY_HD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string SYFX { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string JGLX { get; set; }

        [StringLength(200)]
        public string GS { get; set; }

        [StringLength(50)]
        public string MS { get; set; }
    }
}
