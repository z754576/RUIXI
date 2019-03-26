namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.OccupationalDiseaseSymptoms")]
    public partial class OccupationalDiseaseSymptoms
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        public DateTime? CheckDate { get; set; }

        public DateTime? AppearDate { get; set; }

        [StringLength(20)]
        public string SeverityOfSymptoms { get; set; }

        [Required]
        [StringLength(10)]
        public string CheckDoctor { get; set; }

        public int SymptomsID { get; set; }
    }
}
