namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JBJLB")]
    public partial class TJ_JBJLB
    {
        [Key]
        [StringLength(14)]
        public string JBXH { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(6)]
        public string TJLX { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXMBH { get; set; }

        [StringLength(6)]
        public string TJXMBH { get; set; }

        [Required]
        [StringLength(6)]
        public string JBBH { get; set; }

        [Required]
        [StringLength(100)]
        public string JBMC { get; set; }

        [Required]
        [StringLength(40)]
        public string JCYS { get; set; }

        [StringLength(6)]
        public string ZJYS { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }
    }
}
