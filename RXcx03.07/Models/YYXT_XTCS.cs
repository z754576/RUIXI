namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.YYXT_XTCS")]
    public partial class YYXT_XTCS
    {
        [Key]
        [StringLength(32)]
        public string ZDM { get; set; }

        [Required]
        [StringLength(32)]
        public string MC { get; set; }

        [Required]
        [StringLength(500)]
        public string SZ { get; set; }

        [Required]
        [StringLength(500)]
        public string MS { get; set; }

        [StringLength(10)]
        public string SFXS { get; set; }
    }
}
