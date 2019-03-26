namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.WJ_QUESTIONTYPE")]
    public partial class WJ_QUESTIONTYPE
    {
        public int ID { get; set; }

        public int BH { get; set; }

        public bool? ISENABLE { get; set; }

        [StringLength(250)]
        public string TYPENAME { get; set; }

        public int? PARENTID { get; set; }

        public int? DISPLAYORDER { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [StringLength(20)]
        public string MODIFYUSER { get; set; }
    }
}
