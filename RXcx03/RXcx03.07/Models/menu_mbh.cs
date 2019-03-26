namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.menu_mbh")]
    public partial class menu_mbh
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string station_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string mc { get; set; }

        [StringLength(6)]
        public string zhxgr { get; set; }

        public DateTime? zhxgrq { get; set; }
    }
}
