namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_KSTX")]
    public partial class TJ_KSTX
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string TJBH { get; set; }

        public int TJCS { get; set; }

        [Required]
        [StringLength(20)]
        public string YSGKH { get; set; }

        [StringLength(4000)]
        public string MESSAGE { get; set; }

        public DateTime? ADDTIME { get; set; }
    }
}
