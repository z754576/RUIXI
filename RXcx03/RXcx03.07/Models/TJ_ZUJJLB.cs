namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZUJJLB")]
    public partial class TJ_ZUJJLB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string ZUJKSBH { get; set; }

        public bool? FLAG { get; set; }

        [StringLength(6)]
        public string ZUJYS { get; set; }

        public DateTime? ZUJRQ { get; set; }
    }
}
