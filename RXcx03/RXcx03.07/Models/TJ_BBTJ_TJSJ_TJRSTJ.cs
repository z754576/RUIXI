namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_BBTJ_TJSJ_TJRSTJ")]
    public partial class TJ_BBTJ_TJSJ_TJRSTJ
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string TJID { get; set; }

        [StringLength(25)]
        public string DWBH { get; set; }

        public int? DWTJCS { get; set; }

        public int? NLDXH { get; set; }

        [StringLength(20)]
        public string NLDMC { get; set; }

        public int? MAN { get; set; }

        public int? WOMAN { get; set; }

        public int? QT { get; set; }
    }
}
