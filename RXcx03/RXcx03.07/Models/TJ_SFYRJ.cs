namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SFYRJ")]
    public partial class TJ_SFYRJ
    {
        [StringLength(8)]
        public string ID { get; set; }

        [StringLength(8)]
        public string RJSJ { get; set; }

        [StringLength(10)]
        public string SFCRJID { get; set; }

        [StringLength(1)]
        public string SFCJZHT { get; set; }

        public DateTime? JLSJ { get; set; }

        [StringLength(6)]
        public string GKHM { get; set; }

        [StringLength(14)]
        public string MINSJH { get; set; }

        [StringLength(14)]
        public string MAXSJH { get; set; }

        public int FPZS { get; set; }

        public int SFZS { get; set; }

        public int TKZS { get; set; }

        public int BDZS { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZJJE { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZFJE { get; set; }

        [Column(TypeName = "money")]
        public decimal? JZJE { get; set; }

        [Column(TypeName = "money")]
        public decimal? TKJE { get; set; }

        public decimal XJJE { get; set; }

        public decimal KJE { get; set; }
    }
}
