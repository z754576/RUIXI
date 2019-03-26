namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.LUOXIANG")]
    public partial class LUOXIANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string VALUE_1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string VALUE_2 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string VALUE_3 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string VALUE_5 { get; set; }
    }
}
