namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZJQXB")]
    public partial class TJ_ZJQXB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string GKHM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ZJBH { get; set; }

        [StringLength(1)]
        public string FLAG { get; set; }

        [StringLength(8)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
