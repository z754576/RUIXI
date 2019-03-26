namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.COMPANYJKB")]
    public partial class COMPANYJKB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string QYBH { get; set; }

        [Required]
        [StringLength(100)]
        public string QYMC { get; set; }

        [StringLength(20)]
        public string QYZH { get; set; }

        public DateTime? HQRQ { get; set; }

        [StringLength(1)]
        public string DZZT { get; set; }

        [StringLength(1)]
        public string SCZT { get; set; }
    }
}
