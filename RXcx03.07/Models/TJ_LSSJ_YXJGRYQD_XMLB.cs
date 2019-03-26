namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_LSSJ_YXJGRYQD_XMLB")]
    public partial class TJ_LSSJ_YXJGRYQD_XMLB
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(50)]
        public string XM { get; set; }

        [StringLength(255)]
        public string JBMC { get; set; }

        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(6)]
        public string JBBH { get; set; }
    }
}
