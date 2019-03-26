namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.ShortMessage")]
    public partial class ShortMessage
    {
        [Key]
        public int MessageId { get; set; }

        public int SmsType { get; set; }

        [Required]
        [StringLength(40)]
        public string PhysicalNo { get; set; }

        public int PhysicalTimes { get; set; }

        [Required]
        [StringLength(15)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(300)]
        public string SmContent { get; set; }

        public DateTime MakeTime { get; set; }

        [StringLength(20)]
        public string CreateUserName { get; set; }

        [StringLength(1)]
        public string Sended { get; set; }

        public DateTime? SendTime { get; set; }

        public int SendCount { get; set; }

        [StringLength(60)]
        public string NAME { get; set; }

        [StringLength(40)]
        public string ID { get; set; }

        [StringLength(16)]
        public string DEPT { get; set; }

        [StringLength(12)]
        public string DRDCBH { get; set; }
    }
}
