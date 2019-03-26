namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_PACSBG")]
    public partial class TJ_PACSBG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        public DateTime? RQ { get; set; }

        [Column(TypeName = "image")]
        public byte[] PACSBG { get; set; }
    }
}
