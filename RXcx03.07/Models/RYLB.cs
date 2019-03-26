namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.RYLB")]
    public partial class RYLB
    {
        [Key]
        [StringLength(4)]
        public string BH { get; set; }

        [Required]
        [StringLength(20)]
        public string MC { get; set; }

        [StringLength(8)]
        public string PYJM { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [Required]
        [StringLength(8)]
        public string ZHXGR { get; set; }
    }
}
