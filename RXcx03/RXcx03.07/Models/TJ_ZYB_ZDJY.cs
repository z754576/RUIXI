namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_ZDJY")]
    public partial class TJ_ZYB_ZDJY
    {
        [Key]
        [StringLength(4)]
        public string BH { get; set; }

        [Required]
        [StringLength(1000)]
        public string JL { get; set; }

        [Required]
        [StringLength(1000)]
        public string JY { get; set; }

        [StringLength(6)]
        public string DISPORDER { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [StringLength(4)]
        public string HarmfulFactors { get; set; }
    }
}
