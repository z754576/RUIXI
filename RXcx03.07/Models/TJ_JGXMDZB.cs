namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JGXMDZB")]
    public partial class TJ_JGXMDZB
    {
        [Key]
        [StringLength(6)]
        public string TJMXXM { get; set; }

        [Required]
        [StringLength(40)]
        public string TJMXXMMC { get; set; }

        [Required]
        [StringLength(64)]
        public string GJC { get; set; }

        [StringLength(255)]
        public string GJCMC { get; set; }

        [StringLength(255)]
        public string SM { get; set; }
    }
}
