namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.CDWH")]
    public partial class CDWH
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SJCDBH { get; set; }

        [StringLength(50)]
        public string MC { get; set; }

        public bool? KS { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        [Required]
        [StringLength(10)]
        public string TAG { get; set; }
    }
}
