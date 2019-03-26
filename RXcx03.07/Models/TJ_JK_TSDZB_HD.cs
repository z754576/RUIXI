namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JK_TSDZB_HD")]
    public partial class TJ_JK_TSDZB_HD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BH { get; set; }

        [StringLength(25)]
        public string GJZ { get; set; }

        [StringLength(50)]
        public string MC { get; set; }

        [StringLength(255)]
        public string SM { get; set; }
    }
}
