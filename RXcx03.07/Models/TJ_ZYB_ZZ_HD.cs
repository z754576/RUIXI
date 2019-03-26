namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_ZZ_HD")]
    public partial class TJ_ZYB_ZZ_HD
    {
        [Key]
        public int ZZID { get; set; }

        [StringLength(10)]
        public string ZZMC { get; set; }
    }
}
