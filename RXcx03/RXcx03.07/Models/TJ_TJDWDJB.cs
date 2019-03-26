namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJDWDJB")]
    public partial class TJ_TJDWDJB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string DJXH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string DWBH { get; set; }

        public DateTime DJRQ { get; set; }

        [Required]
        [StringLength(1)]
        public string JZZT { get; set; }

        public DateTime? JZRQ { get; set; }

        [StringLength(14)]
        public string JZSJH { get; set; }

        [StringLength(16)]
        public string DWJZR { get; set; }

        public decimal? JZJE { get; set; }

        [StringLength(6)]
        public string JSR { get; set; }
    }
}
