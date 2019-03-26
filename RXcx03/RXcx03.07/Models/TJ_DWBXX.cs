namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWBXX")]
    public partial class TJ_DWBXX
    {
        [Key]
        [StringLength(25)]
        public string ZDM { get; set; }

        [Required]
        [StringLength(50)]
        public string MC { get; set; }

        [Column(TypeName = "text")]
        public string NR { get; set; }

        [StringLength(1)]
        public string SFXS { get; set; }

        [StringLength(200)]
        public string SM { get; set; }

        [StringLength(6)]
        public string DISP_ORDER { get; set; }
    }
}
