namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBTJ_DWTJBG_NXJBFBQKFX")]
    public partial class TJ_BBTJ_DWTJBG_NXJBFBQKFX
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(64)]
        public string JBMC { get; set; }

        public int? JBRS { get; set; }

        public int? ZRS { get; set; }
    }
}
