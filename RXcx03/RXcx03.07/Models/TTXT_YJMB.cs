namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TTXT_YJMB")]
    public partial class TTXT_YJMB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string NR { get; set; }

        [Required]
        [StringLength(100)]
        public string STMP { get; set; }

        [Required]
        [StringLength(10)]
        public string STMP_PORT { get; set; }

        [Required]
        [StringLength(50)]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAILADDRESS { get; set; }

        public DateTime XGSJ { get; set; }
    }
}
