namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KDJ_XMB")]
    public partial class TJ_KDJ_XMB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TJKBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DJCS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string TJXM { get; set; }

        public int CS { get; set; }

        public int SYCS { get; set; }
    }
}
