namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JK_SELECTCOL")]
    public partial class TJ_JK_SELECTCOL
    {
        public int ID { get; set; }

        public int? JKXH { get; set; }

        [StringLength(50)]
        public string TAB { get; set; }

        [StringLength(50)]
        public string COL { get; set; }
    }
}
