namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.PublishInfo")]
    public partial class PublishInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XTBH { get; set; }

        public int FSDXSL { get; set; }

        public int SCPGSL { get; set; }

        public int XZPGSL { get; set; }

        public int SCBGSL { get; set; }
    }
}
