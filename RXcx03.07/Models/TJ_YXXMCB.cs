namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_YXXMCB")]
    public partial class TJ_YXXMCB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [StringLength(6)]
        public string TJXM { get; set; }

        [StringLength(6)]
        public string TCBH { get; set; }

        [StringLength(1)]
        public string XMLX { get; set; }
    }
}
