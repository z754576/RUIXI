namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBTJ_TJSJ_TJXMHZ")]
    public partial class TJ_BBTJ_TJSJ_TJXMHZ
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(25)]
        public string DWBH { get; set; }

        [StringLength(255)]
        public string TJBH { get; set; }

        public int? TJCS { get; set; }

        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(14)]
        public string RYBH { get; set; }

        [StringLength(50)]
        public string XM { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        public int? NL { get; set; }

        [StringLength(32)]
        public string PHONE { get; set; }

        [StringLength(20)]
        public string MOBILE { get; set; }

        [StringLength(6)]
        public string FZBH { get; set; }

        [StringLength(8000)]
        public string TJXM { get; set; }

        [StringLength(8000)]
        public string JJXM { get; set; }
    }
}
