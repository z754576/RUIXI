namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.user_group")]
    public partial class user_group
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ug_login_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ug_group_id { get; set; }

        [StringLength(50)]
        public string ug_remark { get; set; }

        [MaxLength(20)]
        public byte[] user_password { get; set; }
    }
}
