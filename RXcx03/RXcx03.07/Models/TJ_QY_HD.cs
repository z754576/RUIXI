namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_QY_HD")]
    public partial class TJ_QY_HD
    {
        [Key]
        [StringLength(6)]
        public string BH { get; set; }

        [Required]
        [StringLength(20)]
        public string MC { get; set; }

        public int PLSX { get; set; }

        [Required]
        [StringLength(1)]
        public string SFVIP { get; set; }

        [StringLength(50)]
        public string BZ { get; set; }

        [Required]
        [StringLength(20)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [StringLength(1)]
        public string SYXB { get; set; }

        [StringLength(1)]
        public string PMXSFS { get; set; }

        [StringLength(1)]
        public string PMDLS { get; set; }

        [StringLength(1)]
        public string SFYYJH { get; set; }

        [StringLength(255)]
        public string TOP_XSNR { get; set; }

        [StringLength(255)]
        public string BOTTOM_XSNR { get; set; }
    }
}
