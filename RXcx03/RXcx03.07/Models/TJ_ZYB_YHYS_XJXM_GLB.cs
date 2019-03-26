namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_YHYS_XJXM_GLB")]
    public partial class TJ_ZYB_YHYS_XJXM_GLB
    {
        public int ID { get; set; }

        public int? Factor_Stage_ID { get; set; }

        [StringLength(6)]
        public string ExamItemID { get; set; }

        [StringLength(6)]
        public string DepartmentsID { get; set; }
    }
}
