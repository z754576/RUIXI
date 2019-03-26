namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.PublishControl")]
    public partial class PublishControl
    {
        [Key]
        [StringLength(20)]
        public string PublishId { get; set; }

        [Required]
        [StringLength(20)]
        public string PatientId { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(4)]
        public string Sex { get; set; }

        [StringLength(4)]
        public string Age { get; set; }

        [StringLength(300)]
        public string PublishNote { get; set; }

        public DateTime MakeTime { get; set; }

        public DateTime? SubmitTime { get; set; }

        [Required]
        [StringLength(1)]
        public string ControlType { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(1)]
        public string Published { get; set; }

        public DateTime? CHECK_DATE { get; set; }

        [StringLength(12)]
        public string DJLSH { get; set; }

        [StringLength(14)]
        public string DEPT { get; set; }

        [StringLength(12)]
        public string DRDCBH { get; set; }
    }
}
