namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBQRB")]
    public partial class TJ_BBQRB
    {
        [Key]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(1)]
        public string X { get; set; }

        public DateTime? XRQ { get; set; }

        [Required]
        [StringLength(1)]
        public string XB { get; set; }

        public DateTime? XBRQ { get; set; }

        [Required]
        [StringLength(1)]
        public string DB { get; set; }

        public DateTime? DBRQ { get; set; }
    }
}
