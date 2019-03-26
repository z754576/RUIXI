namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWFZ_HD_LOG")]
    public partial class TJ_DWFZ_HD_LOG
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
    }
}
