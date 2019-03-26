namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.always_function")]
    public partial class always_function
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string func_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string func_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(60)]
        public string func_desc { get; set; }
    }
}
