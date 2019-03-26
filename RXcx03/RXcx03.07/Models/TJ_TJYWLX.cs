namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJYWLX")]
    public partial class TJ_TJYWLX
    {
        [Key]
        [StringLength(2)]
        public string BH { get; set; }

        [Required]
        [StringLength(20)]
        public string MC { get; set; }

        [Required]
        [StringLength(1)]
        public string SFQY { get; set; }

        [StringLength(1)]
        public string SFMRZ { get; set; }
    }
}
