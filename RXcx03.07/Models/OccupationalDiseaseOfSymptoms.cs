namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.OccupationalDiseaseOfSymptoms")]
    public partial class OccupationalDiseaseOfSymptoms
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string SeverityOfSymptomsName { get; set; }
    }
}
