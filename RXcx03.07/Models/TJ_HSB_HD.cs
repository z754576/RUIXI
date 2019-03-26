namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_HSB_HD")]
    public partial class TJ_HSB_HD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string BH { get; set; }

        [StringLength(10)]
        public string TJLX { get; set; }

        [StringLength(6)]
        public string ZHXMBH { get; set; }

        [StringLength(50)]
        public string CKZ { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MC { get; set; }

        [StringLength(255)]
        public string MS { get; set; }
    }
}
