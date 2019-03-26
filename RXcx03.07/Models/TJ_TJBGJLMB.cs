namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TJBGJLMB")]
    public partial class TJ_TJBGJLMB
    {
        public int MBBH { get; set; }

        [StringLength(50)]
        public string MBMC { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string NR { get; set; }

        [StringLength(500)]
        public string BZ { get; set; }

        [StringLength(10)]
        public string CJR { get; set; }

        public DateTime? CJRQ { get; set; }

        [StringLength(10)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        [StringLength(2)]
        public string SFQY { get; set; }

        [StringLength(5)]
        public string SCBS { get; set; }

        [Required]
        [StringLength(50)]
        public string MBLXBH { get; set; }

        [Key]
        public int MBID { get; set; }
    }
}
