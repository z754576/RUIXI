namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.security_groupings")]
    public partial class security_groupings
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string group_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(16)]
        public string user_name { get; set; }
    }
}
