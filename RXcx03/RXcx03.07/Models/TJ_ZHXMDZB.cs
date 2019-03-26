namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZHXMDZB")]
    public partial class TJ_ZHXMDZB
    {
        [Key]
        [StringLength(6)]
        public string TJZHXM { get; set; }

        [StringLength(32)]
        public string TJZHXMMC { get; set; }

        [Required]
        [StringLength(100)]
        public string GJC { get; set; }

        [StringLength(255)]
        public string GJCMC { get; set; }

        [StringLength(255)]
        public string SM { get; set; }
    }
}
