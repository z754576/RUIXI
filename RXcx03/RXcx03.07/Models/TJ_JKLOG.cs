namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JKLOG")]
    public partial class TJ_JKLOG
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string XTMC { get; set; }

        [Required]
        [StringLength(6)]
        public string XMBH { get; set; }

        [Required]
        [StringLength(100)]
        public string XMBH_LIS { get; set; }

        [Required]
        [StringLength(1)]
        public string LX { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(1)]
        public string DZBZ { get; set; }

        public DateTime RQ { get; set; }
    }
}
