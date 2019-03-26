namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DJYYXX_LOG")]
    public partial class TJ_DJYYXX_LOG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string QYBH { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(500)]
        public string YYXX { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }

        [Required]
        [StringLength(20)]
        public string CZY { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CZSJ { get; set; }

        public DateTime? RZSJ { get; set; }
    }
}
