namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KDJB")]
    public partial class TJ_KDJB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TJKBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DJCS { get; set; }

        [StringLength(50)]
        public string GYBH { get; set; }

        [Required]
        [StringLength(4)]
        public string LBBH { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }

        [Required]
        [StringLength(6)]
        public string DJRY { get; set; }

        public DateTime DJRQ { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGRY { get; set; }

        public DateTime ZHXGRQ { get; set; }

        public decimal XSJE { get; set; }

        public decimal? CSJE { get; set; }

        public decimal? SYJE { get; set; }

        [StringLength(6)]
        public string XSR { get; set; }

        public DateTime? XSRQ { get; set; }

        public DateTime YXRQ { get; set; }

        [StringLength(6)]
        public string ZXR { get; set; }

        public DateTime? ZXRQ { get; set; }

        public int? CS { get; set; }

        public int? SYCS { get; set; }

        [StringLength(50)]
        public string GMR { get; set; }

        [StringLength(50)]
        public string GMDW { get; set; }

        [StringLength(30)]
        public string TEL { get; set; }

        [StringLength(50)]
        public string ADDRESS { get; set; }
    }
}
