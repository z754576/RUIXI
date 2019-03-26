namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZY_TJJLMXB")]
    public partial class TJ_ZY_TJJLMXB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string TJXM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string TJZHXM { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BH { get; set; }

        [Required]
        [StringLength(6)]
        public string TJLX { get; set; }
    }
}
