namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SFYRJ_SFLX")]
    public partial class TJ_SFYRJ_SFLX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string RJID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string SFLX { get; set; }

        public decimal JE { get; set; }
    }
}
