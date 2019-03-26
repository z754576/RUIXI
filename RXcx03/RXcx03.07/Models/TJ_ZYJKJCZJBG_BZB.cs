namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYJKJCZJBG_BZB")]
    public partial class TJ_ZYJKJCZJBG_BZB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string BGBH { get; set; }

        public DateTime BZRQ { get; set; }

        [Required]
        [StringLength(50)]
        public string BGMC { get; set; }

        public DateTime CZRQ { get; set; }

        [StringLength(10)]
        public string CZY { get; set; }

        [Required]
        [StringLength(40)]
        public string YRDW { get; set; }

        [StringLength(50)]
        public string WHYS { get; set; }

        [Required]
        [StringLength(50)]
        public string TJLB { get; set; }

        public DateTime? TJRQ { get; set; }

        [StringLength(5)]
        public string TJRS { get; set; }

        [StringLength(4000)]
        public string TJXM { get; set; }

        [StringLength(4000)]
        public string TJJL { get; set; }

        [StringLength(4000)]
        public string CLYJ { get; set; }

        [StringLength(6)]
        public string YB { get; set; }

        [StringLength(32)]
        public string PHONE { get; set; }

        [StringLength(255)]
        public string TJDD { get; set; }

        [StringLength(255)]
        public string DWDZ { get; set; }

        [StringLength(50)]
        public string LXR { get; set; }

        public int DWTJCS { get; set; }

        [StringLength(6)]
        public string JCYS { get; set; }

        [StringLength(20)]
        public string BGH { get; set; }
    }
}
