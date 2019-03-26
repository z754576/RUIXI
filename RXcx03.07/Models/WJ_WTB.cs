namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.WJ_WTB")]
    public partial class WJ_WTB
    {
        public int ID { get; set; }

        public int BH { get; set; }

        [Required]
        [StringLength(800)]
        public string WTNR { get; set; }

        public int SSFL { get; set; }

        public int WTLX { get; set; }

        public int XB { get; set; }

        public int? SSFT { get; set; }

        [Column(TypeName = "image")]
        public byte[] TP { get; set; }

        public bool SFYTP { get; set; }

        [StringLength(800)]
        public string GLXGKS { get; set; }

        public bool SFQY { get; set; }

        public int XH { get; set; }

        [Required]
        [StringLength(6)]
        public string ZHXGR { get; set; }

        public DateTime ZHXGRQ { get; set; }
    }
}
