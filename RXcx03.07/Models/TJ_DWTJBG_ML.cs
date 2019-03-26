namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWTJBG_ML")]
    public partial class TJ_DWTJBG_ML
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Required]
        [StringLength(50)]
        public string MC { get; set; }

        [StringLength(6)]
        public string JBMB { get; set; }

        [StringLength(1)]
        public string SFXS { get; set; }

        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }

        [Column(TypeName = "text")]
        public string NR { get; set; }

        [StringLength(255)]
        public string BZ1 { get; set; }

        [StringLength(255)]
        public string BZ2 { get; set; }

        [StringLength(255)]
        public string BZ3 { get; set; }
    }
}
