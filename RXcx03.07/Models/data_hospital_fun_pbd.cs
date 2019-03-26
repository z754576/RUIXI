namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.data_hospital_fun_pbd")]
    public partial class data_hospital_fun_pbd
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(64)]
        public string Open_win_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string file_code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string hospital_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(64)]
        public string file_name { get; set; }

        [StringLength(128)]
        public string comments { get; set; }

        [Column(TypeName = "text")]
        public string remark { get; set; }
    }
}
