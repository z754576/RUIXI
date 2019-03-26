namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_TABLESYNTAX")]
    public partial class TJ_TABLESYNTAX
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MC { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "text")]
        public string SYNTAX { get; set; }

        [StringLength(50)]
        public string BZ { get; set; }

        public decimal? WIDTH { get; set; }

        public decimal? HEIGHT { get; set; }

        public decimal? CROSSSPACE { get; set; }

        public decimal? DOWNSPACE { get; set; }
    }
}
