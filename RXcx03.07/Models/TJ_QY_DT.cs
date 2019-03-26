namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_QY_DT")]
    public partial class TJ_QY_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ZTBH { get; set; }

        public int XH { get; set; }
    }
}
