namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_FCXMB")]
    public partial class TJ_FCXMB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string TJXMBH { get; set; }

        [StringLength(6)]
        public string JCYS { get; set; }

        public DateTime? JCRQ { get; set; }
    }
}
