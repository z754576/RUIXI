namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_YDTJXMB_LOG")]
    public partial class TJ_YDTJXMB_LOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string YYBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string DWBH { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string TJXMBH { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string XMLX { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string SSLX { get; set; }

        [StringLength(6)]
        public string FZBH { get; set; }
    }
}
