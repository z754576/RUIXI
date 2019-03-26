namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_YHPJDAB")]
    public partial class TJ_YHPJDAB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string WTBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string XH { get; set; }

        [StringLength(100)]
        public string MC { get; set; }

        [StringLength(1)]
        public string FLAG { get; set; }
    }
}
