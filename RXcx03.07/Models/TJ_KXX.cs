namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KXX")]
    public partial class TJ_KXX
    {
        [Key]
        [StringLength(50)]
        public string TJKBH { get; set; }

        public int DJCS { get; set; }

        [StringLength(50)]
        public string GYBH { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }

        public DateTime? DJRQ { get; set; }

        public DateTime? BFRQ { get; set; }
    }
}
