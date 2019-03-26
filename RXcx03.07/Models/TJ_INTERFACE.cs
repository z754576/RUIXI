namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_INTERFACE")]
    public partial class TJ_INTERFACE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDFX { get; set; }

        public int XH { get; set; }

        [StringLength(64)]
        public string INTERFACE { get; set; }

        [StringLength(64)]
        public string DBMS { get; set; }

        [StringLength(64)]
        public string SERVER { get; set; }

        [StringLength(64)]
        public string DBNAME { get; set; }

        [StringLength(64)]
        public string LOGID { get; set; }

        [StringLength(64)]
        public string LOGPASS { get; set; }

        [StringLength(64)]
        public string PARM { get; set; }

        [StringLength(64)]
        public string AUTOCOMMIT { get; set; }

        [StringLength(10)]
        public string INTEGRATEDSECURITY { get; set; }

        public int? ISUSE { get; set; }

        public int? SOFTWARE { get; set; }

        public int? SEND_RYXX { get; set; }

        public int? SEND_XMXX { get; set; }

        [Column(TypeName = "text")]
        public string SELECTTABLE { get; set; }

        [Column(TypeName = "text")]
        public string SELECTFIELD { get; set; }

        [Column(TypeName = "text")]
        public string SELECTJOIN { get; set; }

        [Column(TypeName = "text")]
        public string FIELDOPP { get; set; }

        [Column(TypeName = "text")]
        public string FIELDOPP_XMXX { get; set; }

        [Column(TypeName = "text")]
        public string ARGOPP { get; set; }

        [Column(TypeName = "text")]
        public string ARGOPP_XMXX { get; set; }

        [Column(TypeName = "text")]
        public string REPORT { get; set; }

        [Column(TypeName = "text")]
        public string REPORT_XMXX { get; set; }

        [StringLength(30)]
        public string MIES_XML_WYH { get; set; }

        [StringLength(64)]
        public string RYDJ_TAB { get; set; }

        [Column(TypeName = "text")]
        public string RYDJ_TABLEC { get; set; }

        [Column(TypeName = "text")]
        public string RYDJ_COLUMN { get; set; }

        [Required]
        [StringLength(1)]
        public string RYDJ_SFQY { get; set; }

        [StringLength(64)]
        public string ZHXM_TAB { get; set; }

        [Column(TypeName = "text")]
        public string ZHXM_TABLEC { get; set; }

        [Column(TypeName = "text")]
        public string ZHXM_COLUMN { get; set; }

        [Required]
        [StringLength(1)]
        public string ZHXM_SFQY { get; set; }

        [StringLength(1)]
        public string IS_QY_XML { get; set; }

        [StringLength(100)]
        public string OPPOSING_CPBH { get; set; }

        [StringLength(1)]
        public string RYXX_PROC_SFQY { get; set; }

        [StringLength(500)]
        public string RYXX_PROC { get; set; }

        [StringLength(1)]
        public string XMXX_PROC_SFQY { get; set; }

        [StringLength(500)]
        public string XMXX_PROC { get; set; }
    }
}
