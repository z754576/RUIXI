namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.REPORTINFO")]
    public partial class REPORTINFO
    {
        public int ID { get; set; }

        public int REPORTTYPE { get; set; }

        [Required]
        [StringLength(50)]
        public string FILENAME { get; set; }

        [Required]
        [StringLength(500)]
        public string FILEPATH { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }

        public DateTime UPDATEDATE { get; set; }

        [Required]
        [StringLength(50)]
        public string UPDATEUSER { get; set; }

        public bool ISCURRENT { get; set; }
    }
}
