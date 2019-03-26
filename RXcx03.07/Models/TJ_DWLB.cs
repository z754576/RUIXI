namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWLB")]
    public partial class TJ_DWLB
    {
        [Key]
        [StringLength(2)]
        public string BH { get; set; }

        [Required]
        [StringLength(32)]
        public string MC { get; set; }

        [Required]
        [StringLength(1)]
        public string SFCZBK { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }
    }
}
