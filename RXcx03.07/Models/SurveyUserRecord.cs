namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.SurveyUserRecord")]
    public partial class SurveyUserRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RID { get; set; }

        [Required]
        [StringLength(100)]
        public string SID { get; set; }

        public int DID { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        public bool Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string Birthday { get; set; }

        [StringLength(50)]
        public string Mars { get; set; }

        [Required]
        [StringLength(200)]
        public string Corp { get; set; }

        [StringLength(12)]
        public string DJLSH { get; set; }

        public DateTime MakeTime { get; set; }

        [StringLength(1)]
        public string Sended { get; set; }

        public DateTime? SendTime { get; set; }
    }
}
