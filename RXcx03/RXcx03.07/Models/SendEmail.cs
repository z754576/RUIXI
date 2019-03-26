namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SendEmail")]
    public partial class SendEmail
    {
        [Key]
        [StringLength(20)]
        public string EmailID { get; set; }

        [Required]
        [StringLength(40)]
        public string PhysicalNo { get; set; }

        public int PhysicalTimes { get; set; }

        [Required]
        [StringLength(50)]
        public string Addressee { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(200)]
        public string Subject { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public DateTime MakeTime { get; set; }

        [StringLength(20)]
        public string CreateUserName { get; set; }

        [StringLength(1)]
        public string Sended { get; set; }

        public DateTime? SendTime { get; set; }

        [StringLength(16)]
        public string DEPT { get; set; }

        [StringLength(12)]
        public string DRDCBH { get; set; }
    }
}
