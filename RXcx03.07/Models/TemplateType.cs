namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TemplateType")]
    public partial class TemplateType
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string TemplateTypeName { get; set; }

        [Required]
        [StringLength(10)]
        public string TemplateTypeNumber { get; set; }
    }
}
