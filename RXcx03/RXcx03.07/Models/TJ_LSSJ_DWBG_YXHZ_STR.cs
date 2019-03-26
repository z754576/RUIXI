namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_LSSJ_DWBG_YXHZ_STR")]
    public partial class TJ_LSSJ_DWBG_YXHZ_STR
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(25)]
        public string DWBH { get; set; }

        public int? DWTJCS { get; set; }

        [StringLength(14)]
        public string TJBH { get; set; }

        public int? TJCS { get; set; }

        [StringLength(14)]
        public string RYBH { get; set; }

        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        public int? NL { get; set; }

        public DateTime? DJRQ { get; set; }

        public DateTime? TJRQ { get; set; }

        public DateTime? JCRQ { get; set; }

        [StringLength(6)]
        public string JBBH { get; set; }

        [StringLength(255)]
        public string JBMC { get; set; }
    }
}
