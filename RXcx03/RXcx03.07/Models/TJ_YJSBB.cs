namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_YJSBB")]
    public partial class TJ_YJSBB
    {
        [Key]
        [StringLength(4)]
        public string BH { get; set; }

        [Required]
        [StringLength(64)]
        public string SBMC { get; set; }

        [Required]
        [StringLength(1)]
        public string JCJYLX { get; set; }

        [StringLength(2)]
        public string BBLX { get; set; }

        [StringLength(255)]
        public string SM { get; set; }

        [StringLength(8)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
