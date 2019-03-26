namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBTJ_BZ")]
    public partial class TJ_BBTJ_BZ
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(50)]
        public string BBMC { get; set; }

        [StringLength(50)]
        public string KEYWORD { get; set; }

        [Column(TypeName = "text")]
        public string VALUE { get; set; }
    }
}
