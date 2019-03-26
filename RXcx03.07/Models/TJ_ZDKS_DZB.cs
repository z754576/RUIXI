namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZDKS_DZB")]
    public partial class TJ_ZDKS_DZB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string ZDBH { get; set; }

        [Required]
        [StringLength(6)]
        public string LXBH { get; set; }

        [StringLength(2)]
        public string LCLX { get; set; }
    }
}
