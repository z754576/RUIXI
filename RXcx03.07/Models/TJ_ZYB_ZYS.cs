namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_ZYS")]
    public partial class TJ_ZYB_ZYS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

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

        [StringLength(20)]
        public string GL { get; set; }
    }
}
