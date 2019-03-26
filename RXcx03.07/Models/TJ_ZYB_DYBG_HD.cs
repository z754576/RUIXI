namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_DYBG_HD")]
    public partial class TJ_ZYB_DYBG_HD
    {
        [Key]
        public int BH { get; set; }

        [Required]
        [StringLength(50)]
        public string XSMC { get; set; }

        public int TYPE { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        [StringLength(50)]
        public string JC { get; set; }

        [StringLength(200)]
        public string BZ { get; set; }
    }
}
