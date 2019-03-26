namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_HSB_DT")]
    public partial class TJ_HSB_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [StringLength(6)]
        public string TJXMBH { get; set; }

        [StringLength(50)]
        public string GJZ { get; set; }

        [StringLength(255)]
        public string MC { get; set; }

        [StringLength(50)]
        public string CKZ { get; set; }

        [StringLength(255)]
        public string ZDBH { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        [StringLength(1)]
        public string SFZSYM { get; set; }

        [StringLength(255)]
        public string CKZ2 { get; set; }

        [StringLength(255)]
        public string AGE { get; set; }
    }
}
