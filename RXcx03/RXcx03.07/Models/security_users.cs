namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.security_users")]
    public partial class security_users
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string description { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int priority { get; set; }

        public int? user_type { get; set; }
    }
}
