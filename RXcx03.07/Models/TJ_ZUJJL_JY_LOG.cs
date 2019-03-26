namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZUJJL_JY_LOG")]
    public partial class TJ_ZUJJL_JY_LOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(14)]
        public string BH { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string ZUJKS { get; set; }

        [StringLength(14)]
        public string ZSBH { get; set; }

        [StringLength(255)]
        public string ZDBH { get; set; }

        [StringLength(255)]
        public string JYTT { get; set; }

        [StringLength(2)]
        public string JYLX { get; set; }

        [StringLength(255)]
        public string JYNR { get; set; }

        public int? DISP_ORDER { get; set; }

        public int? DISP_ORDER1 { get; set; }

        public int? DISP_ORDER2 { get; set; }

        public int? DISP_ORDER3 { get; set; }
    }
}
