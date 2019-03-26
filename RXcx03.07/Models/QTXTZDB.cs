namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.QTXTZDB")]
    public partial class QTXTZDB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string XTMC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string LX { get; set; }

        [StringLength(255)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string MC { get; set; }

        [StringLength(255)]
        public string SM { get; set; }
    }
}
