namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_MYPJB")]
    public partial class TJ_MYPJB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        public int WTLX { get; set; }

        public int WTBH { get; set; }

        [StringLength(1)]
        public string PJJG { get; set; }

        [StringLength(255)]
        public string JY { get; set; }
    }
}
