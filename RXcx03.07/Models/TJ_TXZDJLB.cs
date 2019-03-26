namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TXZDJLB")]
    public partial class TJ_TXZDJLB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string JBBH { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(6)]
        public string TJLX { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXMBH { get; set; }

        [StringLength(6)]
        public string TJXMBH { get; set; }

        [Required]
        [StringLength(10)]
        public string JCYS { get; set; }
    }
}
