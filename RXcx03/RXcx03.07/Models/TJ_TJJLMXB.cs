namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJJLMXB")]
    public partial class TJ_TJJLMXB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string TJXM { get; set; }

        [StringLength(4000)]
        public string JG { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string TJZHXM { get; set; }

        [StringLength(6)]
        public string TJLX { get; set; }

        public DateTime? JCRQ { get; set; }

        [StringLength(40)]
        public string JCYS { get; set; }

        [StringLength(4)]
        public string SFLB { get; set; }

        [StringLength(60)]
        public string CKXX { get; set; }

        [StringLength(50)]
        public string TS { get; set; }

        public bool? SFYX { get; set; }

        [StringLength(50)]
        public string DW { get; set; }

        [StringLength(200)]
        public string CKZ { get; set; }
    }
}
