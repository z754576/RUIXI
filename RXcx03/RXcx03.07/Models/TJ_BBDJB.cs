namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBDJB")]
    public partial class TJ_BBDJB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string BBBH { get; set; }

        [Required]
        [StringLength(14)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string ZHXM { get; set; }

        [StringLength(32)]
        public string MC { get; set; }

        [StringLength(100)]
        public string ZHXM_LIS { get; set; }

        [StringLength(255)]
        public string MC_LIS { get; set; }

        [Required]
        [StringLength(1)]
        public string ZT { get; set; }

        [Required]
        [StringLength(2)]
        public string BBLX { get; set; }

        [StringLength(1)]
        public string FLAG { get; set; }

        [StringLength(1)]
        public string PRINTED { get; set; }

        [StringLength(6)]
        public string DJRY { get; set; }

        public DateTime? DJRQ { get; set; }

        [StringLength(6)]
        public string ZXKS { get; set; }

        [StringLength(12)]
        public string SJCXXH { get; set; }

        [StringLength(4)]
        public string DYYJSB { get; set; }
    }
}
