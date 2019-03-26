namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TC_DT")]
    public partial class TJ_TC_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string TCBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ZHXM { get; set; }

        [Required]
        [StringLength(1)]
        public string FLAG { get; set; }
    }
}
