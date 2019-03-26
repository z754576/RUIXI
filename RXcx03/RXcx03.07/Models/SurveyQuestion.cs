namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SurveyQuestion")]
    public partial class SurveyQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QID { get; set; }

        [Required]
        [StringLength(80)]
        public string Title { get; set; }

        [Required]
        [StringLength(80)]
        public string Descr { get; set; }

        [Required]
        [StringLength(80)]
        public string File { get; set; }

        public bool Status { get; set; }

        public bool Required { get; set; }

        public int Value_Type { get; set; }

        public bool Multi { get; set; }

        [Required]
        [StringLength(80)]
        public string Valid_Upper { get; set; }

        [Required]
        [StringLength(80)]
        public string Normal_Upper { get; set; }

        [Required]
        [StringLength(80)]
        public string Normal_Lower { get; set; }

        [Required]
        [StringLength(80)]
        public string Valid_Lower { get; set; }

        [Required]
        [StringLength(80)]
        public string Unit1 { get; set; }
    }
}
