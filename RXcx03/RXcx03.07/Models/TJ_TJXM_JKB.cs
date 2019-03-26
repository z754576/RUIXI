namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJXM_JKB")]
    public partial class TJ_TJXM_JKB
    {
        public int ID { get; set; }

        public int? TJDJJKBID { get; set; }

        [StringLength(20)]
        public string TJXMBH { get; set; }

        [StringLength(500)]
        public string TJXMMC { get; set; }

        public decimal? YJ { get; set; }

        public decimal? ZHJ { get; set; }

        public int? JKZFZT { get; set; }

        public int? MSZFZT { get; set; }

        public int? SCZT { get; set; }

        public int? LY { get; set; }
    }
}
