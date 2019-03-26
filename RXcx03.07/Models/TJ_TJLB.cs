namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJLB")]
    public partial class TJ_TJLB
    {
        [Key]
        [StringLength(2)]
        public string BH { get; set; }

        [Required]
        [StringLength(64)]
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

        [StringLength(2)]
        public string BGLX { get; set; }

        [Required]
        [StringLength(2)]
        public string TJYWLX { get; set; }

        [StringLength(1)]
        public string SFMRZ { get; set; }

        [StringLength(2)]
        public string ZYBLX { get; set; }
    }
}
