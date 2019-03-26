namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SZRMYY_JYK")]
    public partial class TJ_SZRMYY_JYK
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string ZCODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string code { get; set; }

        [StringLength(12)]
        public string RESULT { get; set; }

        [StringLength(8)]
        public string REPORTER { get; set; }

        [StringLength(10)]
        public string RDAY { get; set; }

        [StringLength(8)]
        public string rtime { get; set; }

        [StringLength(4)]
        public string ASK { get; set; }
    }
}
