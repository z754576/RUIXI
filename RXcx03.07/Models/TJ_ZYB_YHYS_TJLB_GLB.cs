namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_YHYS_TJLB_GLB")]
    public partial class TJ_ZYB_YHYS_TJLB_GLB
    {
        public int ID { get; set; }

        public int? FactorID { get; set; }

        [StringLength(2)]
        public string Stage { get; set; }

        [StringLength(200)]
        public string PhysicalCycle { get; set; }
    }
}
