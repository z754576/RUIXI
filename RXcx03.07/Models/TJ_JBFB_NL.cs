namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JBFB_NL")]
    public partial class TJ_JBFB_NL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Required]
        [StringLength(20)]
        public string MC { get; set; }

        public int BEGIN_AGE { get; set; }

        public int END_AGE { get; set; }
    }
}
