namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.ShortMsgModel")]
    public partial class ShortMsgModel
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModelType { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ModelName { get; set; }

        [StringLength(1000)]
        public string ModelContent { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
