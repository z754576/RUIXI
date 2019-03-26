namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.GGWS_JDMC")]
    public partial class GGWS_JDMC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(13)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string MC { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime ZHXGRQ { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string ZHXGR { get; set; }
    }
}
