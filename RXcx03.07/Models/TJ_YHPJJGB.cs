namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_YHPJJGB")]
    public partial class TJ_YHPJJGB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [StringLength(100)]
        public string DJLSH { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string WTBH { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string DAXH { get; set; }
    }
}
