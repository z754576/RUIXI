namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.GGWS_CYRYJBXX")]
    public partial class GGWS_CYRYJBXX
    {
        [Key]
        [StringLength(15)]
        public string BH { get; set; }

        [StringLength(15)]
        public string KH { get; set; }

        [StringLength(20)]
        public string SFZH { get; set; }

        [StringLength(20)]
        public string HYZMBH { get; set; }

        [Required]
        [StringLength(12)]
        public string XM { get; set; }

        [Required]
        [StringLength(1)]
        public string XB { get; set; }

        public DateTime CSRQ { get; set; }

        [StringLength(6)]
        public string FWHY { get; set; }

        [StringLength(6)]
        public string GZDW { get; set; }

        public DateTime QFRQ { get; set; }

        [StringLength(10)]
        public string YXQ { get; set; }

        [StringLength(3)]
        public string JD { get; set; }

        [StringLength(50)]
        public string HJD { get; set; }

        [StringLength(50)]
        public string XZDZ { get; set; }

        [StringLength(12)]
        public string HCRXM { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [Required]
        [StringLength(12)]
        public string ZHXGR { get; set; }

        [StringLength(100)]
        public string BZ { get; set; }
    }
}
