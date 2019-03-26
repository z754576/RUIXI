namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_MBJBB")]
    public partial class TJ_ZYB_MBJBB
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string DiseaseName { get; set; }

        public int? TypeOfDisease { get; set; }

        public int? DiagnosticCriteria { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }

        [StringLength(200)]
        public string SimpleCode { get; set; }

        public bool? DeleteFlag { get; set; }
    }
}
