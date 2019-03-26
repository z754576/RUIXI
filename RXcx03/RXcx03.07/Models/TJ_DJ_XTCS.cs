namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.TJ_DJ_XTCS")]
    public partial class TJ_DJ_XTCS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100)]
        public string SELECT_READER { get; set; }

        public int? KEY_STORE_NO { get; set; }

        [StringLength(2)]
        public string KEY_VALUE_INPUT1 { get; set; }

        [StringLength(2)]
        public string KEY_VALUE_INPUT2 { get; set; }

        [StringLength(2)]
        public string KEY_VALUE_INPUT3 { get; set; }

        [StringLength(2)]
        public string KEY_VALUE_INPUT4 { get; set; }

        [StringLength(2)]
        public string KEY_VALUE_INPUT5 { get; set; }

        [StringLength(2)]
        public string KEY_VALUE_INPUT6 { get; set; }

        public int? A_BLOCK_NO { get; set; }

        public int? A_KEY_STORE_NO { get; set; }

        [StringLength(1)]
        public string A_KEY_TYPE { get; set; }

        public int? B_BLOCK_NO { get; set; }

        public int? B_LENGTH { get; set; }
    }
}
