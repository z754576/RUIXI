namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TXZD")]
    public partial class TJ_TXZD
    {
        [Key]
        [StringLength(6)]
        public string JBBH { get; set; }

        public int XH { get; set; }

        [Required]
        [StringLength(6)]
        public string TJLX { get; set; }

        [StringLength(6)]
        public string ORDER_ID { get; set; }
    }
}
