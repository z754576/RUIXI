namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_FZJL_JCYS")]
    public partial class TJ_FZJL_JCYS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [StringLength(6)]
        public string ZHTZYS { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime JYTZRQ { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string JYYS { get; set; }

        public DateTime? ZHTZRQ { get; set; }

        [StringLength(1)]
        public string TJZFS { get; set; }

        [Required]
        [StringLength(1)]
        public string FLAG { get; set; }

        [StringLength(255)]
        public string BZ { get; set; }

        public DateTime? CZRQ { get; set; }
    }
}
