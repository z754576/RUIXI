namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.security_info")]
    public partial class security_info
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
        [StringLength(16)]
        public string user_name { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string status { get; set; }
    }
}
