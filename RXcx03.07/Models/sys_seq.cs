namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.sys_seq")]
    public partial class sys_seq
    {
        [Key]
        [StringLength(10)]
        public string sq_name { get; set; }

        [StringLength(30)]
        public string sq_display { get; set; }

        [StringLength(16)]
        public string sq_currno { get; set; }

        [StringLength(30)]
        public string sq_remark { get; set; }
    }
}
