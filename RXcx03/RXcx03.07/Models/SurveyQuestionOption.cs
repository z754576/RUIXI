namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SurveyQuestionOption")]
    public partial class SurveyQuestionOption
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OptionOrder { get; set; }

        [Required]
        [StringLength(80)]
        public string Option { get; set; }

        [Required]
        [StringLength(10)]
        public string OptionValue { get; set; }
    }
}
