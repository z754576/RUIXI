namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_FZTZXX")]
    public partial class TJ_FZTZXX
    {
        public int ID { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        [StringLength(200)]
        public string TZJG { get; set; }

        public int? TZDXCS { get; set; }

        [StringLength(6)]
        public string ZHTZRBH { get; set; }

        [StringLength(50)]
        public string ZHTZRName { get; set; }

        public DateTime? ZHTZRQ { get; set; }

        [StringLength(500)]
        public string BZ { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
