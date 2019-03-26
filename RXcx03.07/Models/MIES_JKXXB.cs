namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.MIES_JKXXB")]
    public partial class MIES_JKXXB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string JKBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string JKMC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string FBCPBH { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string FBCPMC { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string JKCPBH { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string JKCPMC { get; set; }

        [StringLength(40)]
        public string QYBZ { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string JKLXMC { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(15)]
        public string FWIP { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FWDK { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BYDK { get; set; }
    }
}
