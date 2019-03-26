namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.GGWS_JHSYXX")]
    public partial class GGWS_JHSYXX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string RQBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string JKZBH { get; set; }

        [StringLength(14)]
        public string TJBH { get; set; }

        public int? TJCS { get; set; }

        [StringLength(40)]
        public string XM { get; set; }

        public int? NL { get; set; }

        [StringLength(50)]
        public string HY { get; set; }

        [StringLength(60)]
        public string HJD { get; set; }

        [StringLength(60)]
        public string XJD { get; set; }

        [StringLength(20)]
        public string BMZJHM { get; set; }

        [StringLength(20)]
        public string HYZMBH { get; set; }

        [StringLength(50)]
        public string BZ { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        [StringLength(20)]
        public string FZDW { get; set; }

        [StringLength(20)]
        public string DWMC { get; set; }

        [StringLength(1)]
        public string BJ { get; set; }
    }
}
