namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_HSB_HS_DETAIL")]
    public partial class TJ_HSB_HS_DETAIL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [StringLength(50)]
        public string ZHXM { get; set; }

        [StringLength(100)]
        public string BDS { get; set; }

        [StringLength(1)]
        public string BDS_LX { get; set; }

        [StringLength(50)]
        public string BDS_Z { get; set; }
    }
}
