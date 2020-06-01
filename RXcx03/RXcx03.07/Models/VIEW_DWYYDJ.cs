namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.VIEW_DWYYDJ")]
    public partial class VIEW_DWYYDJ
    {
        [StringLength(64)]
        public string 单位名称 { get; set; }

        [StringLength(255)]
        public string 分组名称 { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string 预约编号 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string 姓名 { get; set; }

        [StringLength(2)]
        public string 性别 { get; set; }

        public DateTime? 出生日期 { get; set; }

        [StringLength(32)]
        public string 电话号码 { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime 预登记时间 { get; set; }

        public DateTime? 体检时间 { get; set; }

        [StringLength(40)]
        public string 预登记人 { get; set; }

        [StringLength(6)]
        public string 是否到检 { get; set; }
    }
}
