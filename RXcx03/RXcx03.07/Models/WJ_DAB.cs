namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.WJ_DAB")]
    public partial class WJ_DAB
    {
        public int ID { get; set; }

        public int DABH { get; set; }

        public int SSWT { get; set; }

        [Required]
        [StringLength(800)]
        public string DANR { get; set; }

        public decimal FS { get; set; }

        [StringLength(500)]
        public string HCDA { get; set; }

        [StringLength(100)]
        public string SFGL { get; set; }

        [StringLength(800)]
        public string GLJCXM { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }
    }
}
