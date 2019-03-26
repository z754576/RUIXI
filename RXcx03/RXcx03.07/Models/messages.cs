namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.messages")]
    public partial class messages
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string msgid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string msgtitle { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string msgtext { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string msgicon { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(17)]
        public string msgbutton { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int msgdefaultbutton { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int msgseverity { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string msgprint { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1)]
        public string msguserinput { get; set; }
    }
}
