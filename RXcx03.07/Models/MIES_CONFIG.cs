namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.MIES_CONFIG")]
    public partial class MIES_CONFIG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string SVNAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string DBNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string DBUSER { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string DBPASS { get; set; }

        [StringLength(100)]
        public string CPMC { get; set; }

        [StringLength(40)]
        public string QYBZ { get; set; }

        [StringLength(20)]
        public string CPLXMC { get; set; }
    }
}
