namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SurveyPaperList")]
    public partial class SurveyPaperList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string Age { get; set; }

        [StringLength(50)]
        public string Gather { get; set; }

        [Required]
        [StringLength(200)]
        public string Ill { get; set; }

        public int Qcount { get; set; }

        public bool Status { get; set; }

        [StringLength(20)]
        public string Last_Update { get; set; }

        [Column(TypeName = "text")]
        public string Descr { get; set; }
    }
}
