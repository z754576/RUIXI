namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.Msgs")]
    public partial class Msgs
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string MSG { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(50)]
        public string IPAdress { get; set; }
    }
}
