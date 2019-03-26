namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SendEmailAttachments")]
    public partial class SendEmailAttachments
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string EmailID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileOrder { get; set; }

        [Required]
        [StringLength(200)]
        public string FileName { get; set; }

        [Column(TypeName = "image")]
        public byte[] Files { get; set; }
    }
}
