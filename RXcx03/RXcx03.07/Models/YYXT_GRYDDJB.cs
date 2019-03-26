namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.YYXT_GRYDDJB")]
    public partial class YYXT_GRYDDJB
    {
        public int ID { get; set; }

        [Required]
        [StringLength(14)]
        public string YYBH { get; set; }

        [Required]
        [StringLength(50)]
        public string XM { get; set; }

        public bool XB { get; set; }

        [Required]
        [StringLength(18)]
        public string SFZH { get; set; }

        [Required]
        [StringLength(11)]
        public string SJHM { get; set; }

        public DateTime YYTJSJ { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        public bool? HYZK { get; set; }

        public int? NL { get; set; }

        [StringLength(20)]
        public string MZ { get; set; }

        [StringLength(200)]
        public string BZ { get; set; }

        public int SHZT { get; set; }

        public int FSZT { get; set; }

        public DateTime LRSJ { get; set; }

        public DateTime XGSJ { get; set; }

        [Required]
        [StringLength(2)]
        public string TCID { get; set; }

        [Required]
        [StringLength(32)]
        public string TCMC { get; set; }
    }
}
