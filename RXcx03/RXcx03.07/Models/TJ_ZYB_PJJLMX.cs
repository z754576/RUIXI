namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_PJJLMX")]
    public partial class TJ_ZYB_PJJLMX
    {
        public int ID { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        [StringLength(6)]
        public string TJXMBH { get; set; }

        public int MBJBBH { get; set; }

        public int JLFL { get; set; }
    }
}
