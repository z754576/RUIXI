namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.PhysicalBase")]
    public partial class PhysicalBase
    {
        [Key]
        [StringLength(20)]
        public string PublishId { get; set; }

        public int PhysicalId { get; set; }

        [Required]
        [StringLength(15)]
        public string RefNo { get; set; }

        public DateTime PhysicalTime { get; set; }

        [StringLength(80)]
        public string PhysicalOrgan { get; set; }

        [StringLength(40)]
        public string Doctor { get; set; }

        [StringLength(20)]
        public string PhysicalType { get; set; }

        [Column(TypeName = "text")]
        public string Conclusion { get; set; }

        [Column(TypeName = "text")]
        public string Advice { get; set; }

        public float? Fee { get; set; }

        [StringLength(500)]
        public string Content { get; set; }
    }
}
