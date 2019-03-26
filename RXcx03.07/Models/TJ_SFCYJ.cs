namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SFCYJ")]
    public partial class TJ_SFCYJ
    {
        [Key]
        [StringLength(6)]
        public string YF { get; set; }

        [Required]
        [StringLength(8)]
        public string RQFROM { get; set; }

        [Required]
        [StringLength(8)]
        public string RQTO { get; set; }

        public DateTime JLSJ { get; set; }

        [Required]
        [StringLength(10)]
        public string GKHM { get; set; }
    }
}
