namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYTJ_WTMX")]
    public partial class TJ_ZYTJ_WTMX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [StringLength(2)]
        public string TZBH { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string WTBH { get; set; }

        [StringLength(1)]
        public string DABH { get; set; }
    }
}
