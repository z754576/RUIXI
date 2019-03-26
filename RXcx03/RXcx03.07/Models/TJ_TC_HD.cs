namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TC_HD")]
    public partial class TJ_TC_HD
    {
        [Key]
        [StringLength(2)]
        public string BH { get; set; }

        [Required]
        [StringLength(32)]
        public string MC { get; set; }

        public decimal JG { get; set; }

        [StringLength(4)]
        public string SFLB { get; set; }

        [StringLength(1)]
        public string TCLX { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [StringLength(4)]
        public string DISP_ORDER { get; set; }

        public decimal? BZJG { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        public decimal? DZBL { get; set; }

        [StringLength(20)]
        public string JC { get; set; }

        [Required]
        [StringLength(2)]
        public string TJYWLX { get; set; }

        [Column("SFQY ")]
        [StringLength(1)]
        public string SFQY_ { get; set; }

        [StringLength(500)]
        public string JJ { get; set; }
    }
}
