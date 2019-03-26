namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWTJJLB_LOG")]
    public partial class TJ_DWTJJLB_LOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string DWBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DWTJCS { get; set; }

        public DateTime? KSRQ { get; set; }

        public DateTime? JSRQ { get; set; }

        [StringLength(1)]
        public string WCBZ { get; set; }

        [StringLength(1)]
        public string ZDBZ { get; set; }

        [StringLength(40)]
        public string ZHXGR { get; set; }

        public DateTime? ZHXGRQ { get; set; }
    }
}
