namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.WJ_LOADXML")]
    public partial class WJ_LOADXML
    {
        public int ID { get; set; }

        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(18)]
        public string SFZH { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string XMLWJ { get; set; }

        public DateTime SCRQ { get; set; }
    }
}
