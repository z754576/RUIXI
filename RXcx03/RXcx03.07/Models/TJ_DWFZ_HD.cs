namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWFZ_HD")]
    public partial class TJ_DWFZ_HD
    {
        [Key]
        [StringLength(6)]
        public string BH { get; set; }

        [Required]
        [StringLength(25)]
        public string DWBH { get; set; }

        public int DWTJCS { get; set; }

        [Required]
        [StringLength(255)]
        public string FZMC { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        [StringLength(1)]
        public string HYZK { get; set; }

        public int? BOT_AGE { get; set; }

        [StringLength(1)]
        public string INC_BOTAGE { get; set; }

        public int? TOP_AGE { get; set; }

        [StringLength(1)]
        public string INC_TOPAGE { get; set; }

        [StringLength(16)]
        public string ZC { get; set; }

        [StringLength(16)]
        public string ZW { get; set; }

        public decimal? JG { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }

        public decimal BZJG { get; set; }

        public decimal? DZBL { get; set; }

        [StringLength(6)]
        public string JC { get; set; }

        [StringLength(420)]
        public string JCYHYS { get; set; }

        [Required]
        [StringLength(2)]
        public string TJYWLX { get; set; }

        [StringLength(10)]
        public string JFJS { get; set; }

        [StringLength(1)]
        public string JSRS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? XMZK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DWGDJE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? JXXMZK { get; set; }

        [StringLength(1)]
        public string JSFS { get; set; }

        [StringLength(1)]
        public string SFQY { get; set; }

        [StringLength(1)]
        public string JXZFFS { get; set; }

        [StringLength(2)]
        public string TJLB { get; set; }

        [StringLength(1)]
        public string SFBZ { get; set; }

        [StringLength(1)]
        public string FZLB { get; set; }

        [StringLength(50)]
        public string BJBH { get; set; }
    }
}
