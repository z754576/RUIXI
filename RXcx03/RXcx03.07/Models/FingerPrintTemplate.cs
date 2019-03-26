namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.FingerPrintTemplate")]
    public partial class FingerPrintTemplate
    {
        public int ID { get; set; }

        [MaxLength(8000)]
        public byte[] Template10 { get; set; }

        [StringLength(50)]
        public string PatientFileNumber { get; set; }

        [StringLength(50)]
        public string PatientNumber { get; set; }

        public DateTime? RegistrationDate { get; set; }
    }
}
