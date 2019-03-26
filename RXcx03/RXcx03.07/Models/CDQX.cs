namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.CDQX")]
    public partial class CDQX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string GKHM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CDBH { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }
    }
}
