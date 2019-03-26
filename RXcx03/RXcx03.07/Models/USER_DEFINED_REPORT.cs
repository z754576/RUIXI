namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.USER_DEFINED_REPORT")]
    public partial class USER_DEFINED_REPORT
    {
        [Key]
        [StringLength(10)]
        public string DATAWINDOW_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DATAWINDOW_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string REPORT_NAME { get; set; }

        [Required]
        [StringLength(1)]
        public string IS_DEFAULT_DATAWINDOW { get; set; }

        [Required]
        [StringLength(1)]
        public string IS_SYS_DATAWINDOW { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string SYNTAX { get; set; }

        [Column(TypeName = "text")]
        public string SYNTAX_BAK { get; set; }

        public DateTime UPDATE_DATETIME { get; set; }

        public DateTime CREATE_DATETIME { get; set; }

        [Required]
        [StringLength(1)]
        public string IS_NEW_DATAWINDOW { get; set; }

        [StringLength(60)]
        public string DATAWINDOW_OBJECT { get; set; }

        [StringLength(1)]
        public string IS_USED { get; set; }
    }
}
