namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBTJ_ZGBB_DZB")]
    public partial class TJ_BBTJ_ZGBB_DZB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Required]
        [StringLength(25)]
        public string ZD { get; set; }

        [StringLength(6)]
        public string XMBH { get; set; }

        [StringLength(255)]
        public string XMMC { get; set; }

        [StringLength(1)]
        public string SFXSDW { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string REPORTTYPE { get; set; }
    }
}
