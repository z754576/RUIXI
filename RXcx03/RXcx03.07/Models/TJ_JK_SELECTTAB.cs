namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JK_SELECTTAB")]
    public partial class TJ_JK_SELECTTAB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JKXH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TAB { get; set; }

        [StringLength(50)]
        public string TAB_NAME { get; set; }
    }
}
