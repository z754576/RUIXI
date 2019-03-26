namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.menu_module")]
    public partial class menu_module
    {
        [StringLength(10)]
        public string mf_func_id { get; set; }

        [StringLength(50)]
        public string mf_func_desc { get; set; }

        [StringLength(1)]
        public string mf_fun { get; set; }

        [StringLength(10)]
        public string mf_menu_id { get; set; }

        public decimal? mf_order_no { get; set; }

        [StringLength(50)]
        public string mf_object_name { get; set; }

        [StringLength(20)]
        public string mf_picture { get; set; }

        [StringLength(255)]
        public string mf_parm { get; set; }

        [StringLength(50)]
        public string mf_picture_for_jz { get; set; }

        [StringLength(3)]
        public string mf_version { get; set; }

        [StringLength(50)]
        public string mf_tips { get; set; }

        [StringLength(255)]
        public string mf_initdat { get; set; }

        [StringLength(1)]
        public string mf_onlydisplay { get; set; }

        [StringLength(255)]
        public string mf_icon { get; set; }

        public int? mf_x { get; set; }

        public int? mf_y { get; set; }

        public decimal? mf_transparentcolor { get; set; }

        public decimal? mf_textcolor { get; set; }

        public short? mf_textmodel { get; set; }

        [StringLength(50)]
        public string mf_textfont { get; set; }

        public short? mf_textfontsize { get; set; }

        [StringLength(10)]
        public string mf_event { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string mf_m_d { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string station_id { get; set; }
    }
}
