namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_HISJK_RZB")]
    public partial class TJ_HISJK_RZB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(50)]
        public string XM { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CZSJ { get; set; }

        [StringLength(1)]
        public string ZT { get; set; }

        [StringLength(2000)]
        public string RZ { get; set; }
    }
}
