namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_YHPJWTB")]
    public partial class TJ_YHPJWTB
    {
        [Key]
        [StringLength(4)]
        public string BH { get; set; }

        [StringLength(255)]
        public string MC { get; set; }

        [StringLength(1)]
        public string JGLX { get; set; }

        [StringLength(4)]
        public string DISP_ORDER { get; set; }
    }
}
