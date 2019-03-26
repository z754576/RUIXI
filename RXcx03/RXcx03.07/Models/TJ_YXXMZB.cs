namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_YXXMZB")]
    public partial class TJ_YXXMZB
    {
        [Key]
        [StringLength(20)]
        public string BH { get; set; }

        [Required]
        [StringLength(50)]
        public string XM { get; set; }

        [Required]
        [StringLength(1)]
        public string XB { get; set; }

        [StringLength(2)]
        public string TJYWLX { get; set; }

        public int? NL { get; set; }

        [StringLength(2)]
        public string TJLB { get; set; }

        [StringLength(2)]
        public string RYLB { get; set; }

        [StringLength(50)]
        public string BZ { get; set; }

        public DateTime? DJRQ { get; set; }

        [StringLength(20)]
        public string MOBILE { get; set; }

        [StringLength(6)]
        public string CZY { get; set; }

        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(1)]
        public string FLAG { get; set; }
    }
}
