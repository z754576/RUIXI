namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.tzfl_zdcf")]
    public partial class tzfl_zdcf
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BH { get; set; }

        [StringLength(100)]
        public string id { get; set; }

        [Key]
        [Column(Order = 1)]
        public double xh { get; set; }

        [StringLength(10)]
        public string zdmc { get; set; }

        [Key]
        [Column(Order = 2)]
        public double nrhh { get; set; }

        [StringLength(255)]
        public string zdnrcf { get; set; }
    }
}
