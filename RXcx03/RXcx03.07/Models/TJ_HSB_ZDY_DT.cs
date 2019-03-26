namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_HSB_ZDY_DT")]
    public partial class TJ_HSB_ZDY_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [StringLength(100)]
        public string MC { get; set; }

        [StringLength(50)]
        public string CKZ_SX { get; set; }

        [StringLength(50)]
        public string CKZ_XX { get; set; }

        [StringLength(50)]
        public string DZM { get; set; }

        [StringLength(10)]
        public string TJLX { get; set; }

        [StringLength(200)]
        public string BZ { get; set; }
    }
}
