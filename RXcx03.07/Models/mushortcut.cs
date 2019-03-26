namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.mushortcut")]
    public partial class mushortcut
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string hospital_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string userid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string mf_func_id { get; set; }

        public int? mf_order_no { get; set; }

        [StringLength(10)]
        public string mf_m_d { get; set; }
    }
}
