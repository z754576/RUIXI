namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBTJ_TJSJ_YXJGRYQD_XMLB")]
    public partial class TJ_BBTJ_TJSJ_YXJGRYQD_XMLB
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(255)]
        public string JBBH { get; set; }

        [StringLength(255)]
        public string JBMC { get; set; }

        public decimal? RS { get; set; }

        public decimal? ZJRS { get; set; }

        [Column(TypeName = "text")]
        public string XM { get; set; }
    }
}
