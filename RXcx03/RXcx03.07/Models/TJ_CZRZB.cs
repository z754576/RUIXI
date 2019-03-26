namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_CZRZB")]
    public partial class TJ_CZRZB
    {
        [Required]
        [StringLength(1)]
        public string CZLX { get; set; }

        [Required]
        [StringLength(10)]
        public string CZYBH { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CZYXM { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CZSJ { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CZCK { get; set; }

        [Column(TypeName = "text")]
        public string CZNR { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CZDN { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int? TJCS { get; set; }
    }
}
