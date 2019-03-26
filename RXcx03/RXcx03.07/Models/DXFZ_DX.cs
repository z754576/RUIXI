namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.DXFZ_DX")]
    public partial class DXFZ_DX
    {
        [Key]
        public int BH { get; set; }

        public int FZBH { get; set; }

        [Required]
        [StringLength(50)]
        public string JC { get; set; }

        [Required]
        [StringLength(260)]
        public string NR { get; set; }
    }
}
