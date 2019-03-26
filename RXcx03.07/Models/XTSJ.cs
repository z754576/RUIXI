namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.XTSJ")]
    public partial class XTSJ
    {
        [StringLength(1)]
        public string ID { get; set; }
    }
}
