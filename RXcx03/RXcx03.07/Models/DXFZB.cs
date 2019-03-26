namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.DXFZB")]
    public partial class DXFZB
    {
        [Key]
        public int BH { get; set; }

        public int SJBH { get; set; }

        [Required]
        [StringLength(50)]
        public string FZMC { get; set; }
    }
}
