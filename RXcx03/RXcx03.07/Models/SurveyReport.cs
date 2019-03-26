namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SurveyReport")]
    public partial class SurveyReport
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EID { get; set; }

        [Required]
        [StringLength(100)]
        public string Evaluator { get; set; }

        [Required]
        [StringLength(200)]
        public string Ill { get; set; }

        public double Result { get; set; }

        public double Improvable { get; set; }

        public DateTime MakeDate { get; set; }
    }
}
