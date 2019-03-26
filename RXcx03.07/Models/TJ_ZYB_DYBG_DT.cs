namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_DYBG_DT")]
    public partial class TJ_ZYB_DYBG_DT
    {
        [Key]
        public int BH { get; set; }

        public int BGBH { get; set; }

        [Required]
        [StringLength(25)]
        public string XMBH { get; set; }

        [Required]
        [StringLength(100)]
        public string XMMC { get; set; }
    }
}
