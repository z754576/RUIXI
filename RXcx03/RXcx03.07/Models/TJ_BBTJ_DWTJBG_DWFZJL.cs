namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBTJ_DWTJBG_DWFZJL")]
    public partial class TJ_BBTJ_DWTJBG_DWFZJL
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(14)]
        public string TJBH { get; set; }

        public int? TJCS { get; set; }

        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(4)]
        public string XB { get; set; }

        public int? NL { get; set; }

        [StringLength(8000)]
        public string FCXM { get; set; }
    }
}
