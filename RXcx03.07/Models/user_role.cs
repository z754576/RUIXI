namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.user_role")]
    public partial class user_role
    {
        [Key]
        [StringLength(10)]
        public string um_role_id { get; set; }

        [StringLength(50)]
        public string um_name { get; set; }

        public decimal? um_user_level { get; set; }
    }
}
