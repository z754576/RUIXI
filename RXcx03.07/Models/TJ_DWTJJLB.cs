namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWTJJLB")]
    public partial class TJ_DWTJJLB
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

        [StringLength(1)]
        public string WJBZ { get; set; }

        [StringLength(1)]
        public string DCBZ { get; set; }

        [StringLength(1)]
        public string ZKFS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ZKJE { get; set; }

        [StringLength(10)]
        public string ZKRYBH { get; set; }

        public DateTime? ZKRQ { get; set; }

        [StringLength(1)]
        public string SFBZ { get; set; }

        [StringLength(10)]
        public string JSFS { get; set; }

        [StringLength(10)]
        public string JLR { get; set; }

        public DateTime? JLRQ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DWYFJE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? YFYE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? YFJE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? YFJE2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DWGDJE { get; set; }

        [StringLength(50)]
        public string WJH { get; set; }

        [StringLength(50)]
        public string CSLB { get; set; }

        [StringLength(1)]
        public string SFCF { get; set; }

        [StringLength(1)]
        public string SFQY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? WFJE { get; set; }

        [StringLength(50)]
        public string HTBH2 { get; set; }

        [StringLength(50)]
        public string HTZRS { get; set; }

        [StringLength(50)]
        public string HTZJE { get; set; }
    }
}
