namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.QXKZ")]
    public partial class QXKZ
    {
        [Key]
        [StringLength(6)]
        public string MKBBH { get; set; }

        [Required]
        [StringLength(6)]
        public string YYBH { get; set; }

        [Required]
        [StringLength(4)]
        public string DLSBH { get; set; }

        [Required]
        [StringLength(8)]
        public string MKJCRQ { get; set; }

        [Required]
        [StringLength(2)]
        public string MKSYZ { get; set; }

        [Required]
        [StringLength(1)]
        public string MKSFBS { get; set; }

        [Required]
        [StringLength(30)]
        public string JYM { get; set; }
    }
}
