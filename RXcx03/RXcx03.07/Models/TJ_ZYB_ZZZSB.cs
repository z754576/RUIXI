namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_ZZZSB")]
    public partial class TJ_ZYB_ZZZSB
    {
        public int ID { get; set; }

        [StringLength(40)]
        public string CertificationsName { get; set; }

        public int? CertificationsType { get; set; }

        [Column(TypeName = "image")]
        public byte[] CertificationsFile { get; set; }

        [Column(TypeName = "image")]
        public byte[] Thumbnail { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        [StringLength(80)]
        public string ImagePath { get; set; }
    }
}
