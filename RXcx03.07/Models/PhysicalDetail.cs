namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.PhysicalDetail")]
    public partial class PhysicalDetail
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

        [Key]
        [Column(Order = 3)]
        [StringLength(60)]
        public string ItemName { get; set; }

        [Required]
        [StringLength(30)]
        public string Sample { get; set; }

        [Required]
        [StringLength(60)]
        public string Place { get; set; }

        public bool? ResultFlag { get; set; }

        [StringLength(20)]
        public string ResultUnit { get; set; }

        [StringLength(500)]
        public string ResultValue { get; set; }

        [StringLength(300)]
        public string ResultNote { get; set; }

        [StringLength(100)]
        public string ResultExplain { get; set; }

        [StringLength(60)]
        public string RefRange { get; set; }

        [StringLength(40)]
        public string Doctor { get; set; }

        public float? Fee { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public int DISP_ORDER { get; set; }
    }
}
