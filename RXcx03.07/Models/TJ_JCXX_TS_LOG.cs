namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JCXX_TS_LOG")]
    public partial class TJ_JCXX_TS_LOG
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string DataType { get; set; }

        [Required]
        [StringLength(50)]
        public string DataNumber { get; set; }
    }
}
