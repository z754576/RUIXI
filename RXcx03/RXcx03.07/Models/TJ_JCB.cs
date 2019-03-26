namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JCB")]
    public partial class TJ_JCB
    {
        [Key]
        [StringLength(6)]
        public string DJDLH { get; set; }

        [Required]
        [StringLength(6)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        [Required]
        [StringLength(10)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(10)]
        public string XM { get; set; }

        [Required]
        [StringLength(10)]
        public string XB { get; set; }

        [Required]
        [StringLength(1)]
        public string SFJC { get; set; }
    }
}
