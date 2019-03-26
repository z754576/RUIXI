namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBDJMXB")]
    public partial class TJ_BBDJMXB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ZHXMBH { get; set; }

        [Required]
        [StringLength(32)]
        public string ZHXMMC { get; set; }

        [StringLength(100)]
        public string ZHXMBH_LIS { get; set; }

        [StringLength(255)]
        public string ZHXMMC_LIS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string XMBH_TJ { get; set; }

        [Required]
        [StringLength(40)]
        public string XMMC_TJ { get; set; }

        [StringLength(64)]
        public string XMBH { get; set; }

        [StringLength(255)]
        public string XMMC { get; set; }

        [StringLength(1)]
        public string ZT { get; set; }
    }
}
