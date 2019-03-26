namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWFZ_DT")]
    public partial class TJ_DWFZ_DT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string FZBH { get; set; }

        [Required]
        [StringLength(25)]
        public string DWBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string TJXM { get; set; }

        [Required]
        [StringLength(1)]
        public string XMLX { get; set; }

        [Required]
        [StringLength(1)]
        public string FLAG { get; set; }
    }
}
