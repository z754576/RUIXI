namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.sys_user")]
    public partial class sys_user
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string u_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string u_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string u_zjm { get; set; }

        [MaxLength(20)]
        public byte[] u_pwd { get; set; }

        [StringLength(2)]
        public string user_level { get; set; }
    }
}
