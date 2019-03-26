namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DLB")]
    public partial class TJ_DLB
    {
        [Required]
        [StringLength(6)]
        public string DJDLH { get; set; }

        [Required]
        [StringLength(6)]
        public string QYBH { get; set; }

        [Required]
        [StringLength(6)]
        public string ZTMC { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(50)]
        public string XM { get; set; }

        [Required]
        [StringLength(4)]
        public string TJXM { get; set; }

        public int JCSJ { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }

        public DateTime? TJSJ { get; set; }

        [Required]
        [StringLength(6)]
        public string CZY { get; set; }

        [StringLength(6)]
        public string JCYS { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        [Key]
        public int XH { get; set; }
    }
}
