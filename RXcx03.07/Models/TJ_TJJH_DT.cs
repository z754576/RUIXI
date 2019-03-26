namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJJH_DT")]
    public partial class TJ_TJJH_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string JHH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Required]
        [StringLength(30)]
        public string DWBH { get; set; }

        [StringLength(6)]
        public string FZBH { get; set; }

        [StringLength(1)]
        public string XB { get; set; }

        public int RS { get; set; }

        [StringLength(50)]
        public string BZ { get; set; }
    }
}
