namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_JWBS_Temp")]
    public partial class TJ_ZYB_JWBS_Temp
    {
        public int ID { get; set; }

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

        [Required]
        [StringLength(20)]
        public string Clientip { get; set; }

        public bool? ISNew { get; set; }

        [StringLength(40)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
