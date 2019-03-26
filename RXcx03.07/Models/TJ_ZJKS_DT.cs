namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZJKS_DT")]
    public partial class TJ_ZJKS_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string ZJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string TJLX { get; set; }

        [StringLength(8)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        [StringLength(4)]
        public string DISP_ORDER { get; set; }
    }
}
