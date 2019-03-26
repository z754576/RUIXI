namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.USER_DEFINED_PBL")]
    public partial class USER_DEFINED_PBL
    {
        [Key]
        public int PBL_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string PBL_NAME { get; set; }

        [Column(TypeName = "image")]
        public byte[] SYNTAX { get; set; }

        [Column(TypeName = "image")]
        public byte[] SYNTAX_BAK { get; set; }

        public DateTime UPDATE_DATETIME { get; set; }

        public DateTime CREATE_DATETIME { get; set; }
    }
}
