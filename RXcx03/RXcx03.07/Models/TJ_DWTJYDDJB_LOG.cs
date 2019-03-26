namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWTJYDDJB_LOG")]
    public partial class TJ_DWTJYDDJB_LOG
    {
        [Required]
        [StringLength(25)]
        public string DWBH { get; set; }

        [Key]
        [StringLength(16)]
        public string YYBH { get; set; }

        public int? DWTJCS { get; set; }

        [StringLength(14)]
        public string RYBH { get; set; }

        [Required]
        [StringLength(40)]
        public string XM { get; set; }

        [Required]
        [StringLength(1)]
        public string XB { get; set; }

        public DateTime? CSNYR { get; set; }

        public int? NL { get; set; }

        [StringLength(16)]
        public string ZC { get; set; }

        [StringLength(16)]
        public string ZW { get; set; }

        [StringLength(1)]
        public string HYZK { get; set; }

        [StringLength(2)]
        public string TJLB { get; set; }

        [StringLength(2)]
        public string RYLB { get; set; }

        public DateTime TJRQ { get; set; }

        [Required]
        [StringLength(6)]
        public string DJRY { get; set; }

        public DateTime DJRQ { get; set; }

        [StringLength(1)]
        public string JSFS { get; set; }

        [StringLength(1)]
        public string FZFS { get; set; }

        [Required]
        [StringLength(1)]
        public string DJBZ { get; set; }

        [StringLength(6)]
        public string FZBH { get; set; }

        [StringLength(18)]
        public string SFZH { get; set; }

        [StringLength(14)]
        public string TJBH { get; set; }

        [StringLength(50)]
        public string BMBH { get; set; }

        public int? BQGS { get; set; }

        [StringLength(32)]
        public string PHONE { get; set; }

        public int? TJCS { get; set; }

        [StringLength(20)]
        public string RSDAH { get; set; }

        [StringLength(30)]
        public string YHYS { get; set; }

        [StringLength(30)]
        public string GZ { get; set; }

        [StringLength(20)]
        public string JSGL { get; set; }

        [StringLength(20)]
        public string ZGL { get; set; }
    }
}
