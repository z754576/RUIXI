namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWTJYDDJB_ZYB_JWBS")]
    public partial class TJ_DWTJYDDJB_ZYB_JWBS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string DWBH { get; set; }

        [Required]
        [StringLength(16)]
        public string YYBH { get; set; }

        [Required]
        [StringLength(18)]
        public string SFZH { get; set; }

        [Required]
        [StringLength(100)]
        public string JBMC { get; set; }

        public DateTime? ZDRQ { get; set; }

        [Required]
        [StringLength(200)]
        public string ZDDW { get; set; }

        [StringLength(400)]
        public string ZLJG { get; set; }

        [StringLength(200)]
        public string ZG { get; set; }

        public bool? ISNew { get; set; }

        [StringLength(40)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
