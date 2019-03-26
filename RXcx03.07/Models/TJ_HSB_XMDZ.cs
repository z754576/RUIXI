namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_HSB_XMDZ")]
    public partial class TJ_HSB_XMDZ
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string HSID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string GJZ { get; set; }

        [StringLength(50)]
        public string MC { get; set; }

        [StringLength(50)]
        public string DZM { get; set; }

        [StringLength(50)]
        public string BZ { get; set; }

        public int? DISP_ORDER { get; set; }

        [StringLength(50)]
        public string DZM1 { get; set; }
    }
}
