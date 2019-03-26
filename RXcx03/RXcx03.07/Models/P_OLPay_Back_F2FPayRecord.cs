namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.P_OLPay_Back_F2FPayRecord")]
    public partial class P_OLPay_Back_F2FPayRecord
    {
        [Key]
        public int RecordID { get; set; }

        [Required]
        [StringLength(40)]
        public string onlyNum { get; set; }

        public decimal realMoney { get; set; }

        [Required]
        [StringLength(40)]
        public string orderNum { get; set; }

        [Required]
        [StringLength(2)]
        public string paymentType { get; set; }

        [Required]
        [StringLength(40)]
        public string TradeNo { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
