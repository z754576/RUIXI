namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_JYJGDR_CS")]
    public partial class TJ_JYJGDR_CS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TS { get; set; }

        [StringLength(1)]
        public string SFFG { get; set; }
    }
}
