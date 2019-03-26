namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DLB_LOG")]
    public partial class TJ_DLB_LOG
    {
        [Required]
        [StringLength(6)]
        public string DJDLH { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Required]
        [StringLength(6)]
        public string QYBH { get; set; }

        [Required]
        [StringLength(6)]
        public string ZTMC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(9)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(50)]
        public string XM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string TJXM { get; set; }

        [Required]
        [StringLength(50)]
        public string CZY { get; set; }

        public DateTime? TJSJ { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime RZSJ { get; set; }

        [StringLength(6)]
        public string JCYS { get; set; }
    }
}
