namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_PACSHD")]
    public partial class TJ_PACSHD
    {
        [Key]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        public int? NL { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }
    }
}
