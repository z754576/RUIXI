namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JK_DZB")]
    public partial class TJ_JK_DZB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JKXH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string LX { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string TAB { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string COL { get; set; }

        [StringLength(50)]
        public string DZM { get; set; }

        [StringLength(1)]
        public string PK { get; set; }
    }
}
