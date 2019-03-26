namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_FCTZZYSX")]
    public partial class TJ_FCTZZYSX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string MS { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        [StringLength(40)]
        public string CJRY { get; set; }

        public DateTime? CJSJ { get; set; }
    }
}
