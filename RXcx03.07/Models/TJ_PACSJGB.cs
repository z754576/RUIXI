namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_PACSJGB")]
    public partial class TJ_PACSJGB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(100)]
        public string ZHXMBH { get; set; }

        [StringLength(255)]
        public string ZHXMMC { get; set; }

        [StringLength(100)]
        public string ZHXMBH_PACS { get; set; }

        [StringLength(255)]
        public string ZHXMMC_PACS { get; set; }

        [StringLength(100)]
        public string PACSDJH { get; set; }

        [StringLength(2000)]
        public string JG { get; set; }

        [StringLength(4000)]
        public string JCSJ { get; set; }

        [StringLength(1900)]
        public string JL { get; set; }

        [StringLength(1)]
        public string ZT { get; set; }

        [StringLength(40)]
        public string SHR { get; set; }

        public DateTime? SHRQ { get; set; }

        [StringLength(1)]
        public string TPZT { get; set; }

        [StringLength(1000)]
        public string JCQKFZSM { get; set; }

        [StringLength(2000)]
        public string TPLJ { get; set; }

        [Column(TypeName = "image")]
        public byte[] PACSBG { get; set; }

        [StringLength(40)]
        public string CZY { get; set; }

        public DateTime? SYSDATETIME { get; set; }

        public int? JKID { get; set; }

        [StringLength(1)]
        public string FLAG { get; set; }
    }
}
