namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DWTJBG")]
    public partial class TJ_DWTJBG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string DWBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string BGMLBH { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BGXH { get; set; }

        [Column(TypeName = "text")]
        public string NR { get; set; }
    }
}
