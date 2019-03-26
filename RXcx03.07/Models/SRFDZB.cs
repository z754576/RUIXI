namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SRFDZB")]
    public partial class SRFDZB
    {
        [Key]
        [StringLength(2)]
        public string HZNM { get; set; }

        [StringLength(1)]
        public string PYJM { get; set; }

        [StringLength(4)]
        public string WBJM { get; set; }

        [StringLength(5)]
        public string ZDYM { get; set; }
    }
}
