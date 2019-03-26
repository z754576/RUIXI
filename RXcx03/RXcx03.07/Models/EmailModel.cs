namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.EmailModel")]
    public partial class EmailModel
    {
        [Key]
        [StringLength(50)]
        public string ModelName { get; set; }

        [StringLength(50)]
        public string EmailTitle { get; set; }

        [StringLength(1000)]
        public string EmailContent { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
