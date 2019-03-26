namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJXMB")]
    public partial class TJ_TJXMB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string LXBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string TJXM { get; set; }

        [Required]
        [StringLength(40)]
        public string MC { get; set; }

        [StringLength(20)]
        public string DW { get; set; }

        [StringLength(20)]
        public string CKXX { get; set; }

        [StringLength(20)]
        public string CKSX { get; set; }

        [StringLength(255)]
        public string ZCTS { get; set; }

        [StringLength(20)]
        public string PDTS { get; set; }

        [StringLength(20)]
        public string PGTS { get; set; }

        [StringLength(255)]
        public string CKJG { get; set; }

        [StringLength(6)]
        public string JCJYXMBH { get; set; }

        [Required]
        [StringLength(1)]
        public string XB { get; set; }

        public decimal? DJ { get; set; }

        [StringLength(20)]
        public string SXXZ { get; set; }

        [StringLength(20)]
        public string XXXZ { get; set; }

        [StringLength(1)]
        public string HAS_IMAGE { get; set; }

        [StringLength(255)]
        public string IMAGE_NAME { get; set; }

        [StringLength(4)]
        public string SFLB { get; set; }

        [StringLength(6)]
        public string DISP_ORDER { get; set; }

        [StringLength(1)]
        public string SFXJ { get; set; }

        [StringLength(1)]
        public string MCJRXJ { get; set; }

        [StringLength(20)]
        public string NXCKXX { get; set; }

        [StringLength(20)]
        public string NXCKSX { get; set; }

        [StringLength(1)]
        public string QYBZ { get; set; }

        [StringLength(1)]
        public string JGLX { get; set; }

        [StringLength(2)]
        public string LCLX { get; set; }
    }
}
