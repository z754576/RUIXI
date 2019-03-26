namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KSDLB")]
    public partial class TJ_KSDLB
    {
        [Key]
        [StringLength(4)]
        public string KSBH { get; set; }

        public int RS { get; set; }

        [Required]
        [StringLength(1)]
        public string SFQY { get; set; }

        public int JCSJ { get; set; }

        public DateTime RQ { get; set; }

        [Required]
        [StringLength(2)]
        public string DJSX { get; set; }
    }
}
