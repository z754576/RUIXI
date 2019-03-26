namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SFYRJ_DT")]
    public partial class TJ_SFYRJ_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string SFLB { get; set; }

        [StringLength(16)]
        public string SFLBMC { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZJJE { get; set; }

        [Column(TypeName = "money")]
        public decimal? ZFJE { get; set; }

        [Column(TypeName = "money")]
        public decimal? JZJE { get; set; }
    }
}
