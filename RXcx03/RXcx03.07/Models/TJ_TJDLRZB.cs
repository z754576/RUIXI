namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJDLRZB")]
    public partial class TJ_TJDLRZB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(6)]
        public string QYBH { get; set; }

        [Required]
        [StringLength(6)]
        public string ZTMC { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }
    }
}
