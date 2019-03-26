namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_PACSDT")]
    public partial class TJ_PACSDT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ZHXM { get; set; }

        [StringLength(32)]
        public string MC { get; set; }

        [StringLength(100)]
        public string ZHXM_PACS { get; set; }

        [StringLength(255)]
        public string MC_PACS { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }

        [StringLength(255)]
        public string MXXMMC { get; set; }

        [StringLength(100)]
        public string PACSDJH { get; set; }
    }
}
