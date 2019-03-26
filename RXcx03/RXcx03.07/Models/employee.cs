namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.employee")]
    public partial class employee
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string emp_di { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string emp_name { get; set; }
    }
}
