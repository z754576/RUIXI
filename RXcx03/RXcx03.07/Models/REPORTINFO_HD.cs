namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.REPORTINFO_HD")]
    public partial class REPORTINFO_HD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BH { get; set; }

        [Required]
        [StringLength(50)]
        public string MC { get; set; }

        [Required]
        [StringLength(50)]
        public string JC { get; set; }

        public int LX { get; set; }

        [StringLength(10)]
        public string TemplateNumber { get; set; }
    }
}
