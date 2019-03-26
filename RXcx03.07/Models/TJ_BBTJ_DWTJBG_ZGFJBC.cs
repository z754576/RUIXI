namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBTJ_DWTJBG_ZGFJBC")]
    public partial class TJ_BBTJ_DWTJBG_ZGFJBC
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(64)]
        public string TJBH { get; set; }

        [StringLength(64)]
        public string XM { get; set; }

        [StringLength(10)]
        public string CSNYR { get; set; }

        [StringLength(64)]
        public string HYZK { get; set; }

        [StringLength(64)]
        public string JCYS { get; set; }

        [StringLength(64)]
        public string DJLSH { get; set; }

        [StringLength(64)]
        public string DWBH { get; set; }

        [StringLength(64)]
        public string BMBH { get; set; }

        public int? NL { get; set; }

        [StringLength(7000)]
        public string XJ { get; set; }

        [StringLength(64)]
        public string YWH { get; set; }
    }
}
