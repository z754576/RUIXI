namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_YSXX")]
    public partial class TJ_YSXX
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string GKHM { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(6)]
        public string ZTBH { get; set; }

        [Required]
        [StringLength(6)]
        public string TJXMBH { get; set; }

        public DateTime CZSJ { get; set; }

        [Required]
        [StringLength(1)]
        public string PJBZ { get; set; }
    }
}
