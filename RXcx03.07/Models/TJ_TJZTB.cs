namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJZTB")]
    public partial class TJ_TJZTB
    {
        [Key]
        [StringLength(6)]
        public string BH { get; set; }

        [Required]
        [StringLength(20)]
        public string MC { get; set; }

        [Required]
        [StringLength(2)]
        public string TJLX { get; set; }

        public int HZSXSJ { get; set; }

        [StringLength(1)]
        public string SYXB { get; set; }

        [StringLength(1)]
        public string ZT { get; set; }

        [Required]
        [StringLength(20)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }

        public int? PJJCSJ { get; set; }

        [StringLength(1)]
        public string DYPD { get; set; }

        [StringLength(1)]
        public string SFQYDL { get; set; }

        [StringLength(1)]
        public string PMSFXS { get; set; }

        [StringLength(1000)]
        public string JJ { get; set; }

        [Column(TypeName = "image")]
        public byte[] CTP { get; set; }

        [Column(TypeName = "image")]
        public byte[] BTP { get; set; }

        [StringLength(200)]
        public string DJTSXX { get; set; }
    }
}
