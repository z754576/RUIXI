namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SFCRJ")]
    public partial class TJ_SFCRJ
    {
        [StringLength(8)]
        public string ID { get; set; }

        [StringLength(1)]
        public string RJBZ { get; set; }

        [StringLength(8)]
        public string RJSJ { get; set; }

        [StringLength(8)]
        public string YJID { get; set; }

        public DateTime? JLSJ { get; set; }

        [StringLength(10)]
        public string GKHM { get; set; }
    }
}
