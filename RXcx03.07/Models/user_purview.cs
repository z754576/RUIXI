namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.user_purview")]
    public partial class user_purview
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string uf_login_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string uf_func_id { get; set; }

        [StringLength(1)]
        public string uf_add { get; set; }

        [StringLength(1)]
        public string uf_delete { get; set; }

        [StringLength(1)]
        public string uf_edit { get; set; }

        [StringLength(1)]
        public string uf_print { get; set; }

        [StringLength(10)]
        public string last_update_by { get; set; }

        public DateTime? last_update_date { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string mf_version { get; set; }

        public int? mf_x { get; set; }

        public int? mf_y { get; set; }

        [StringLength(10)]
        public string station_id { get; set; }
    }
}
