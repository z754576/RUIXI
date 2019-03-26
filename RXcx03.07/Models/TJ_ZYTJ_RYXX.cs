namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYTJ_RYXX")]
    public partial class TJ_ZYTJ_RYXX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [Required]
        [StringLength(40)]
        public string XM { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        public int? NL { get; set; }

        public DateTime? CSNYR { get; set; }

        [StringLength(18)]
        public string SFZH { get; set; }

        [StringLength(1)]
        public string HYZK { get; set; }

        [StringLength(20)]
        public string DWBH { get; set; }

        public int? DWTJCS { get; set; }

        [StringLength(20)]
        public string A { get; set; }

        [StringLength(20)]
        public string B { get; set; }

        [StringLength(20)]
        public string C { get; set; }

        [StringLength(20)]
        public string D { get; set; }

        [StringLength(20)]
        public string E { get; set; }

        [StringLength(20)]
        public string F { get; set; }

        [StringLength(20)]
        public string G { get; set; }

        [StringLength(20)]
        public string H { get; set; }

        [StringLength(20)]
        public string I { get; set; }

        [StringLength(255)]
        public string JG { get; set; }

        [StringLength(18)]
        public string TZBH { get; set; }

        public DateTime? TBRQ { get; set; }

        [StringLength(20)]
        public string TBR { get; set; }

        [StringLength(1000)]
        public string BZ { get; set; }
    }
}
