namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TSDZB")]
    public partial class TJ_TSDZB
    {
        public int ID { get; set; }

        [StringLength(40)]
        public string XSNR { get; set; }

        [StringLength(255)]
        public string CSNR { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }
    }
}
