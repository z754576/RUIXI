namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.COMPANYJKB_GLB")]
    public partial class COMPANYJKB_GLB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string QYBH { get; set; }

        [StringLength(100)]
        public string QYMC { get; set; }

        [Required]
        [StringLength(25)]
        public string DWBH { get; set; }

        [StringLength(64)]
        public string DWMC { get; set; }

        public DateTime? DZRQ { get; set; }
    }
}
