namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.WJ_TMGLKS")]
    public partial class WJ_TMGLKS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TMID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LXBH { get; set; }

        [Required]
        [StringLength(40)]
        public string KSMC { get; set; }
    }
}
