namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_HISJK_RYXX")]
    public partial class TJ_HISJK_RYXX
    {
        [Key]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        [StringLength(1)]
        public string ZT { get; set; }
    }
}
