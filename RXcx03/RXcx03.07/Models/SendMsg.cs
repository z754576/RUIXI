namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SendMsg")]
    public partial class SendMsg
    {
        public int ID { get; set; }

        public int MsgsID { get; set; }

        public int NO { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
