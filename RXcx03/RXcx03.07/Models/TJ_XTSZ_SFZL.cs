namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_XTSZ_SFZL")]
    public partial class TJ_XTSZ_SFZL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MC { get; set; }

        public int? ZHXMZK { get; set; }

        public int? TCZK { get; set; }

        [StringLength(10)]
        public string ZKMS { get; set; }

        public int? ZJZKBL { get; set; }

        [StringLength(50)]
        public string BZ { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
