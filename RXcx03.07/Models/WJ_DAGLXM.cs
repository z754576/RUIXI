namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.WJ_DAGLXM")]
    public partial class WJ_DAGLXM
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TMID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DAID { get; set; }

        [Required]
        [StringLength(6)]
        public string TJLX { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string XMBH { get; set; }

        [Required]
        [StringLength(32)]
        public string XMMC { get; set; }
    }
}
