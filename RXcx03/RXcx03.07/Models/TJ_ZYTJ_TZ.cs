namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYTJ_TZ")]
    public partial class TJ_ZYTJ_TZ
    {
        [Required]
        [StringLength(2)]
        public string BH { get; set; }

        [Required]
        [StringLength(100)]
        public string MC { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [StringLength(1000)]
        public string MS { get; set; }

        [StringLength(1000)]
        public string BZ { get; set; }
    }
}
