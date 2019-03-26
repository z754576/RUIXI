namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_FZMX")]
    public partial class TJ_FZMX
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
        public DateTime JYTZRQ { get; set; }

        [Required]
        [StringLength(100)]
        public string ZHXM { get; set; }

        public DateTime? ZHTZRQ { get; set; }

        public DateTime? FZRQ { get; set; }

        [StringLength(1)]
        public string TZFLAG { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string JCYS { get; set; }

        public DateTime? JCRQ { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string ZHXMBH { get; set; }

        [Required]
        [StringLength(2)]
        public string ZJZT { get; set; }
    }
}
