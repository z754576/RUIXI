namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBTJ_DWTJBG_GFBTJ")]
    public partial class TJ_BBTJ_DWTJBG_GFBTJ
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(100)]
        public string JBMC { get; set; }

        public int? RS { get; set; }

        [StringLength(4)]
        public string YEAR { get; set; }
    }
}
