namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JYJGB")]
    public partial class TJ_JYJGB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(6)]
        public string ZHXMBH { get; set; }

        [StringLength(32)]
        public string ZHXMMC { get; set; }

        [StringLength(100)]
        public string ZHXMBH_LIS { get; set; }

        [StringLength(255)]
        public string ZHXMMC_LIS { get; set; }

        [StringLength(6)]
        public string XMBH_TJ { get; set; }

        [StringLength(40)]
        public string XMMC_TJ { get; set; }

        [Required]
        [StringLength(64)]
        public string XMBH { get; set; }

        [StringLength(255)]
        public string XMMC { get; set; }

        [StringLength(255)]
        public string JG { get; set; }

        [StringLength(50)]
        public string DW { get; set; }

        [StringLength(200)]
        public string CKFW { get; set; }

        [StringLength(1)]
        public string ZT { get; set; }

        [StringLength(40)]
        public string SHR { get; set; }

        public DateTime? SHRQ { get; set; }

        [StringLength(50)]
        public string PROMPT { get; set; }

        [StringLength(40)]
        public string CZY { get; set; }

        public DateTime? SYSDATETIME { get; set; }

        [StringLength(1)]
        public string FLAG { get; set; }
    }
}
