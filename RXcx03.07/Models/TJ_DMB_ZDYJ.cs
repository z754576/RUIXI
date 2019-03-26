namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DMB_ZDYJ")]
    public partial class TJ_DMB_ZDYJ
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MS { get; set; }
    }
}
