namespace RXcx03._07.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("futian_user.VIEW_DJCX123")]
    public partial class VIEW_DJCX123
    {
        [StringLength(40)]
        public string 姓名 { get; set; }

        public DateTime? 登记日期 { get; set; }

        [StringLength(12)]
        public string 登记流水号 { get; set; }

        [StringLength(14)]
        public string 体检编号 { get; set; }

        public int? 体检次数 { get; set; }

        public int? 年龄 { get; set; }

        [StringLength(2)]
        public string 性别 { get; set; }

        [StringLength(6)]
        public string 体检状态 { get; set; }

        [StringLength(32)]
        public string 联系方式 { get; set; }

        [StringLength(32)]
        public string 身份证号 { get; set; }

        [StringLength(64)]
        public string 单位编号 { get; set; }

        [Key]
        public decimal 项目单价 { get; set; }

        [StringLength(32)]
        public string 项目名称 { get; set; }

        [StringLength(255)]
        public string 体检小结 { get; set; }

        [StringLength(32)]
        public string 科室 { get; set; }

        [StringLength(32)]
        public string 检查状态 { get; set; }

        [StringLength(255)]
        public string 备注 { get; set; }

        [StringLength(255)]
        public string 单位分组 { get; set; }

        [StringLength(32)]
        public string 套餐名称 { get; set; }

        [StringLength(6)]
        public string 项目编号 { get; set; }

        [StringLength(255)]
        public string 外送项目 { get; set; }

        [StringLength(32)]
        public string 介绍人 { get; set; }
    }
}
