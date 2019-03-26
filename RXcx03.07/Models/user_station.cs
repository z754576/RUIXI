namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.user_station")]
    public partial class user_station
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string station_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string hospital_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string station_name { get; set; }

        [StringLength(64)]
        public string comments { get; set; }

        public int? station_level { get; set; }

        [Column(TypeName = "text")]
        public string module_liblist { get; set; }
    }
}
