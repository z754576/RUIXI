namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.P_OLPay_Back_SentPlatformRecord")]
    public partial class P_OLPay_Back_SentPlatformRecord
    {
        [Key]
        [StringLength(40)]
        public string onlyNum { get; set; }

        public DateTime sendTime { get; set; }
    }
}
