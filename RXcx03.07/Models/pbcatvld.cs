namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.pbcatvld")]
    public partial class pbcatvld
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string pbv_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(254)]
        public string pbv_vald { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short pbv_type { get; set; }

        public int? pbv_cntr { get; set; }

        [StringLength(254)]
        public string pbv_msg { get; set; }
    }
}
