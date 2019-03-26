namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.CONTORL_DRIVER_INFO")]
    public partial class CONTORL_DRIVER_INFO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string MC { get; set; }

        [Required]
        [StringLength(1)]
        public string LX { get; set; }

        [Required]
        [StringLength(255)]
        public string WJLJ { get; set; }

        [Required]
        [StringLength(255)]
        public string WJMC32 { get; set; }

        [Required]
        [StringLength(255)]
        public string WJMC64 { get; set; }

        [StringLength(255)]
        public string SM { get; set; }
    }
}
