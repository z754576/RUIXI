namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SEED")]
    public partial class TJ_SEED
    {
        [Key]
        [StringLength(16)]
        public string MC { get; set; }

        [StringLength(8)]
        public string RQSTRING { get; set; }

        [StringLength(14)]
        public string XH { get; set; }

        public int? MAXBH { get; set; }
    }
}
