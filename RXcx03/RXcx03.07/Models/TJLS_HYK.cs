namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJLS_HYK")]
    public partial class TJLS_HYK
    {
        [Key]
        [StringLength(25)]
        public string KH { get; set; }

        [Required]
        [StringLength(25)]
        public string GYH { get; set; }

        [Required]
        [StringLength(1)]
        public string KLX { get; set; }

        [Required]
        [StringLength(25)]
        public string HYID { get; set; }

        [Required]
        [StringLength(18)]
        public string SFZH { get; set; }

        [Required]
        [StringLength(4)]
        public string CBFD { get; set; }

        [Required]
        [StringLength(1)]
        public string KZT { get; set; }

        public DateTime BDSJ { get; set; }
    }
}
