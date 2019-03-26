namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.XTGL_TJJGFD")]
    public partial class XTGL_TJJGFD
    {
        [Key]
        [StringLength(4)]
        public string BH { get; set; }

        [Required]
        [StringLength(50)]
        public string MC { get; set; }

        [StringLength(50)]
        public string DZ { get; set; }

        [StringLength(20)]
        public string LXR { get; set; }

        [StringLength(50)]
        public string DH { get; set; }
    }
}
