namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ETYYZKPGB_NEW")]
    public partial class TJ_ETYYZKPGB_NEW
    {
        public int ID { get; set; }

        public double? YEAR { get; set; }

        public double? MONTH { get; set; }

        public decimal? HEIGHT { get; set; }

        public decimal? MDEIAN1 { get; set; }

        public decimal? MDEIAN2 { get; set; }

        public decimal? MDEIAN3 { get; set; }

        public decimal? MDEIAN4 { get; set; }

        public decimal? MDEIAN5 { get; set; }

        [StringLength(1)]
        public string SEX { get; set; }

        [StringLength(1)]
        public string TYPE { get; set; }
    }
}
