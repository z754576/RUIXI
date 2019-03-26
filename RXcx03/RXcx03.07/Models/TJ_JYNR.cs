namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JYNR")]
    public partial class TJ_JYNR
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string TJLX { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string JYBH { get; set; }

        [Required]
        [StringLength(255)]
        public string JYNR { get; set; }

        [StringLength(2)]
        public string JYLX { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        public int? DISP_ORDER { get; set; }
    }
}
