namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KSX")]
    public partial class TJ_KSX
    {
        [Key]
        [StringLength(1)]
        public string BH { get; set; }

        [StringLength(30)]
        public string MC { get; set; }
    }
}
