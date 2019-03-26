namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.sys_code")]
    public partial class sys_code
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string value { get; set; }

        [StringLength(50)]
        public string display { get; set; }

        [StringLength(50)]
        public string remark { get; set; }
    }
}
