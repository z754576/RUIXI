namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.security_apps")]
    public partial class security_apps
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string application { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string description { get; set; }
    }
}
