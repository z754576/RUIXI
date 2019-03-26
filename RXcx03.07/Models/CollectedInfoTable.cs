namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.CollectedInfoTable")]
    public partial class CollectedInfoTable
    {
        [Key]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Required]
        [StringLength(20)]
        public string PublishId { get; set; }

        public DateTime? XGSJ { get; set; }

        public int Published { get; set; }

        public int Exported { get; set; }
    }
}
