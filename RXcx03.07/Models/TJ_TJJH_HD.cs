namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJJH_HD")]
    public partial class TJ_TJJH_HD
    {
        [Key]
        [StringLength(12)]
        public string JHH { get; set; }

        public DateTime KSRQ { get; set; }

        public DateTime JSRQ { get; set; }

        [StringLength(1)]
        public string WCBZ { get; set; }

        public DateTime? WCSJ { get; set; }

        [StringLength(50)]
        public string BZ { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
