namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBTJ_DWTJBG_FKJCHZ")]
    public partial class TJ_BBTJ_DWTJBG_FKJCHZ
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(64)]
        public string TJBH { get; set; }

        [StringLength(64)]
        public string XM { get; set; }

        public int? NL { get; set; }

        [StringLength(64)]
        public string TJXMBH { get; set; }

        [StringLength(64)]
        public string TJXM { get; set; }

        public DateTime? TJRQ { get; set; }

        [StringLength(7000)]
        public string XJ { get; set; }
    }
}
