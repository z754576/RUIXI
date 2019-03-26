namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_PACS_TP")]
    public partial class TJ_PACS_TP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SQDH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string TPMC { get; set; }
    }
}
