namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_CZFZ_DT")]
    public partial class TJ_CZFZ_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string FZBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ZHXM { get; set; }

        [Required]
        [StringLength(1)]
        public string FLAG { get; set; }
    }
}
