namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JKPG_DZB")]
    public partial class TJ_JKPG_DZB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QID { get; set; }

        [StringLength(6)]
        public string TJXMBH { get; set; }

        [StringLength(40)]
        public string SM { get; set; }
    }
}
