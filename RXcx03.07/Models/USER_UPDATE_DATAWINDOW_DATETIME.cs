namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.USER_UPDATE_DATAWINDOW_DATETIME")]
    public partial class USER_UPDATE_DATAWINDOW_DATETIME
    {
        [Key]
        [StringLength(255)]
        public string VOLUME_INFORMATION_ID { get; set; }

        public DateTime UPDATE_DATETIME { get; set; }
    }
}
