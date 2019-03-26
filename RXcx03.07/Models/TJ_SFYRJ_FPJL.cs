namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_SFYRJ_FPJL")]
    public partial class TJ_SFYRJ_FPJL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HH { get; set; }

        [StringLength(14)]
        public string FPHFROM { get; set; }

        [StringLength(14)]
        public string FPHTO { get; set; }

        public int FPZS { get; set; }

        [StringLength(10)]
        public string FPQZ { get; set; }

        [StringLength(10)]
        public string FPHMF { get; set; }

        [StringLength(10)]
        public string FPHMT { get; set; }
    }
}
