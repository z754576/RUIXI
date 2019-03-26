namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJLS_HYXX")]
    public partial class TJLS_HYXX
    {
        [Key]
        [StringLength(25)]
        public string HYID { get; set; }

        public DateTime ZCRQ { get; set; }

        [Required]
        [StringLength(18)]
        public string SFZH { get; set; }

        [Required]
        [StringLength(50)]
        public string XM { get; set; }

        [Required]
        [StringLength(1)]
        public string XB { get; set; }

        public int NL { get; set; }

        public DateTime CSRQ { get; set; }

        [Required]
        [StringLength(1)]
        public string HYZK { get; set; }

        [StringLength(50)]
        public string LXDH { get; set; }

        [StringLength(50)]
        public string LXDZ { get; set; }

        [Required]
        [StringLength(20)]
        public string MOBILE { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        public DateTime ZHXGSJ { get; set; }
    }
}
