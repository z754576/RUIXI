namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.user_master")]
    public partial class user_master
    {
        [Key]
        [StringLength(10)]
        public string um_login_id { get; set; }

        [StringLength(50)]
        public string um_name { get; set; }

        [StringLength(10)]
        public string um_password { get; set; }

        public decimal? um_user_level { get; set; }

        [StringLength(1)]
        public string um_group_or_user { get; set; }
    }
}
