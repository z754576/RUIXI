namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TMBQSZ")]
    public partial class TJ_TMBQSZ
    {
        [Key]
        [StringLength(50)]
        public string FACENAME { get; set; }

        [StringLength(5)]
        public string HEIGHT { get; set; }

        [StringLength(10)]
        public string WEIGHT { get; set; }

        [StringLength(1)]
        public string ITALIC { get; set; }
    }
}
