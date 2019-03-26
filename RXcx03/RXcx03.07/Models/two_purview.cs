namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.two_purview")]
    public partial class two_purview
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string fun_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string station_code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string ref_type { get; set; }

        [StringLength(30)]
        public string flag { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string fun_id { get; set; }

        [StringLength(30)]
        public string func_desc { get; set; }
    }
}
