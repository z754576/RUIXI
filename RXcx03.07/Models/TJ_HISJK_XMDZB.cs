namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_HISJK_XMDZB")]
    public partial class TJ_HISJK_XMDZB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string XMBH { get; set; }

        [Required]
        [StringLength(50)]
        public string XMMC { get; set; }

        [Required]
        [StringLength(255)]
        public string HIS_SFDM { get; set; }

        [StringLength(255)]
        public string HIS_SFXMMC { get; set; }

        public int? SL { get; set; }

        public decimal? DJ { get; set; }

        [Required]
        [StringLength(1)]
        public string DZFS { get; set; }
    }
}
