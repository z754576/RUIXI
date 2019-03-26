namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.hospital")]
    public partial class hospital
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string hospital_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string hospital_name { get; set; }
    }
}
