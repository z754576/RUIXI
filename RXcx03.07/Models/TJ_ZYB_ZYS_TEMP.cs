namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_ZYS_TEMP")]
    public partial class TJ_ZYB_ZYS_TEMP
    {
        public int ID { get; set; }

        [StringLength(18)]
        public string SFZH { get; set; }

        public DateTime? QSRQ { get; set; }

        public DateTime? ZZRQ { get; set; }

        [StringLength(50)]
        public string GZDW { get; set; }

        [StringLength(30)]
        public string CJ { get; set; }

        [StringLength(30)]
        public string GZ { get; set; }

        [StringLength(255)]
        public string YHYS { get; set; }

        [StringLength(255)]
        public string FHCS { get; set; }

        public bool? ISNew { get; set; }

        [StringLength(20)]
        public string ClientIP { get; set; }

        [StringLength(40)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        public int? GL { get; set; }
    }
}
