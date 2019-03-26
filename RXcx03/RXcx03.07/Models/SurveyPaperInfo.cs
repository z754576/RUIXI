namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SurveyPaperInfo")]
    public partial class SurveyPaperInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SID { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        public int Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string Birthday { get; set; }

        [StringLength(50)]
        public string Mars { get; set; }

        [Required]
        [StringLength(200)]
        public string Corp { get; set; }
    }
}
