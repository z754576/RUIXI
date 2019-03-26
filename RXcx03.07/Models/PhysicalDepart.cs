namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.PhysicalDepart")]
    public partial class PhysicalDepart
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PublishId { get; set; }

        public int PhysicalId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short GroupId { get; set; }

        [StringLength(8)]
        public string DepartmentId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string Department { get; set; }

        [Required]
        [StringLength(8)]
        public string ItemId { get; set; }

        [Required]
        [StringLength(60)]
        public string ItemName { get; set; }

        public DateTime PhysicalDate { get; set; }

        [StringLength(40)]
        public string Doctor { get; set; }

        [StringLength(500)]
        public string Summary { get; set; }

        public float? Fee { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public int DISP_ORDER { get; set; }
    }
}
