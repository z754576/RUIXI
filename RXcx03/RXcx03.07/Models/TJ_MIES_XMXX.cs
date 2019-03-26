namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_MIES_XMXX")]
    public partial class TJ_MIES_XMXX
    {
        [Required]
        [StringLength(12)]
        public string DJLSH { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string TJBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TJCS { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int XH { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string TJXMBH { get; set; }

        [StringLength(1)]
        public string ZHBZ { get; set; }

        public DateTime? XTSJ { get; set; }
    }
}
