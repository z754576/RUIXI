namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SUGGESTION")]
    public partial class TJ_SUGGESTION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string BH { get; set; }

        [StringLength(64)]
        public string MC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string TJLX { get; set; }

        [Required]
        [StringLength(255)]
        public string KEYWORD { get; set; }

        [StringLength(255)]
        public string SECWORD { get; set; }

        public decimal? BOTLIMIT { get; set; }

        public decimal? TOPLIMIT { get; set; }

        [StringLength(6)]
        public string TJXM { get; set; }

        [StringLength(6)]
        public string JBBH { get; set; }

        [StringLength(1)]
        public string JGLX { get; set; }

        [StringLength(50)]
        public string ICD { get; set; }

        [StringLength(800)]
        public string JYNR { get; set; }

        [Required]
        [StringLength(1)]
        public string SFCJB { get; set; }

        public int? DISP_ORDER { get; set; }

        [StringLength(255)]
        public string SJBH { get; set; }

        [StringLength(255)]
        public string BHZF { get; set; }

        [Column(TypeName = "text")]
        public string EXPLAIN { get; set; }

        [StringLength(2)]
        public string LCLX { get; set; }

        [StringLength(10)]
        public string PYJM { get; set; }

        [StringLength(4)]
        public string WBJM { get; set; }

        [StringLength(8000)]
        public string OccupationalDiseaseSuggest { get; set; }
    }
}
