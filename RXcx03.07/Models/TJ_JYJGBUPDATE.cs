namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JYJGBUPDATE")]
    public partial class TJ_JYJGBUPDATE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(100)]
        public string ZHXMBH_LIS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string XMBH { get; set; }

        [StringLength(255)]
        public string JG { get; set; }

        [StringLength(50)]
        public string DW { get; set; }

        [StringLength(40)]
        public string CKFW { get; set; }

        [StringLength(40)]
        public string SHR { get; set; }

        public DateTime? SHRQ { get; set; }

        [StringLength(50)]
        public string PROMPT { get; set; }

        [StringLength(1)]
        public string ZT { get; set; }

        public DateTime? SJ { get; set; }
    }
}
