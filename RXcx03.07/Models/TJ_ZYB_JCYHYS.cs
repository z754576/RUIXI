namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_ZYB_JCYHYS")]
    public partial class TJ_ZYB_JCYHYS
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string TJBH { get; set; }

        public int? TJCS { get; set; }

        [StringLength(20)]
        public string JCYHYSBH { get; set; }
    }
}
