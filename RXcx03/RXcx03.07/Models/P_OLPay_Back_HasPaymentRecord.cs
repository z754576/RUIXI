namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.P_OLPay_Back_HasPaymentRecord")]
    public partial class P_OLPay_Back_HasPaymentRecord
    {
        [Key]
        [StringLength(40)]
        public string onlyNum { get; set; }

        public decimal deserveMoney { get; set; }

        public decimal realMoney { get; set; }

        [Required]
        [StringLength(40)]
        public string orderNum_platform { get; set; }

        [Required]
        [StringLength(40)]
        public string organizationNum { get; set; }

        [StringLength(2)]
        public string paymentType { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
