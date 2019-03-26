namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_GG")]
    public partial class TJ_GG
    {
        [Key]
        [StringLength(4)]
        public string BH { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string GG { get; set; }
    }
}
