namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_YGYYDZB")]
    public partial class TJ_YGYYDZB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(2)]
        public string YYXJG { get; set; }

        [StringLength(64)]
        public string DZXX { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        [StringLength(1)]
        public string LX { get; set; }
    }
}
