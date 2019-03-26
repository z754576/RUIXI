namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.tj_report_twxminfo")]
    public partial class tj_report_twxminfo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string jsjmc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string TJXMBH { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(7)]
        public string tw_type { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int xh { get; set; }

        [StringLength(100)]
        public string tpmcA { get; set; }

        [StringLength(100)]
        public string tpmcB { get; set; }
    }
}
