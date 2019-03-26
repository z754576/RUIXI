namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.security_template")]
    public partial class security_template
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string application { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string window { get; set; }

        [Key]
        [Column(Order = 2)]
        public string control { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(254)]
        public string description { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(24)]
        public string object_type { get; set; }
    }
}
