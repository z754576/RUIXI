namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.ShortMessageRev")]
    public partial class ShortMessageRev
    {
        [Key]
        public int PID { get; set; }

        public int MessageId { get; set; }

        [Required]
        [StringLength(15)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(300)]
        public string SmContent { get; set; }

        public DateTime RevTime { get; set; }

        [Required]
        [StringLength(25)]
        public string CreateTime { get; set; }
    }
}
