namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KEYWORD")]
    public partial class TJ_KEYWORD
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BH { get; set; }

        [StringLength(255)]
        public string MC { get; set; }

        [StringLength(255)]
        public string MS { get; set; }

        [StringLength(255)]
        public string KEYWORD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string TJLX { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string TJXM { get; set; }

        public bool? QZ { get; set; }

        [StringLength(6)]
        public string JBBH { get; set; }

        [StringLength(1)]
        public string INTO_XJ { get; set; }

        [StringLength(1)]
        public string SFYX { get; set; }

        [StringLength(4)]
        public string DISP_ORDER { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        public decimal? XY { get; set; }

        public decimal? DY { get; set; }

        [StringLength(2)]
        public string JGLX { get; set; }

        [StringLength(1)]
        public string MCJRXJ { get; set; }

        [StringLength(10)]
        public string PYJM { get; set; }

        [StringLength(4)]
        public string WBJM { get; set; }

        [StringLength(4)]
        public string NLXX { get; set; }

        [StringLength(4)]
        public string NLSX { get; set; }

        [StringLength(1)]
        public string SFZC { get; set; }
    }
}
