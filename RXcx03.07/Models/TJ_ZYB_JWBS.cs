namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_JWBS")]
    public partial class TJ_ZYB_JWBS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(6)]
        public string BH { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

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
    }
}
