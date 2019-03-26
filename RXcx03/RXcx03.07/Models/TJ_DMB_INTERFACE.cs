namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DMB_INTERFACE")]
    public partial class TJ_DMB_INTERFACE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(40)]
        public string FIELDNAME { get; set; }

        [StringLength(40)]
        public string FIELDCHINANAME { get; set; }

        [StringLength(20)]
        public string DATATYPE { get; set; }

        public int? LENGTH { get; set; }

        [StringLength(6)]
        public string FIELDFX { get; set; }

        public bool? ISDICT { get; set; }

        [StringLength(10)]
        public string XXFL { get; set; }
    }
}
