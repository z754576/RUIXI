namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SJH_SFLX")]
    public partial class TJ_SJH_SFLX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string SJH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string SFLX { get; set; }

        [StringLength(20)]
        public string KH { get; set; }

        public decimal JE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string SFTF { get; set; }

        [Required]
        [StringLength(9)]
        public string SFY { get; set; }

        public DateTime SFRQ { get; set; }
    }
}
