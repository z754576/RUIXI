namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_LCLXB")]
    public partial class TJ_LCLXB
    {
        [Key]
        [StringLength(2)]
        public string LCLX { get; set; }

        [Required]
        [StringLength(40)]
        public string MC { get; set; }

        [StringLength(6)]
        public string DISP_ORDER { get; set; }

        [StringLength(64)]
        public string BZ { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        [StringLength(20)]
        public string COLOR { get; set; }
    }
}
