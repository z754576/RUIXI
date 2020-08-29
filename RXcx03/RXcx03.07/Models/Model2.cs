namespace RXcx03._07.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }


       // public virtual DbSet<VIEW_DJCX> VIEW_DJCX { get; set; }
        public virtual DbSet<VIEW_DWYYDJ> VIEW_DWYYDJ { get; set; }
        public virtual DbSet<VIEW_DJCX123> VIEW_DJCX123 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.姓名)
            //    .IsUnicode(false);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.登记流水号)
            //    .IsUnicode(false);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.体检编号)
            //    .IsUnicode(false);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.性别)
            //    .IsUnicode(false);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.体检状态)
            //    .IsUnicode(false);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.联系方式)
            //    .IsUnicode(false);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.单位编号)
            //    .IsUnicode(false);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.项目单价)
            //    .HasPrecision(8, 2);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.项目名称)
            //    .IsUnicode(false);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.套餐名称)
            //    .IsUnicode(false);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.项目编号)
            //    .IsFixedLength()
            //    .IsUnicode(false);

            //modelBuilder.Entity<VIEW_DJCX>()
            //    .Property(e => e.外送项目)
            //    .IsUnicode(false);

            modelBuilder.Entity<VIEW_DWYYDJ>()
                .Property(e => e.单位名称)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DWYYDJ>()
                .Property(e => e.分组名称)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DWYYDJ>()
                .Property(e => e.预约编号)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DWYYDJ>()
                .Property(e => e.姓名)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DWYYDJ>()
                .Property(e => e.性别)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DWYYDJ>()
                .Property(e => e.电话号码)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DWYYDJ>()
                .Property(e => e.预登记人)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DWYYDJ>()
                .Property(e => e.是否到检)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
               .Property(e => e.姓名)
               .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.登记流水号)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.体检编号)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.性别)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.体检状态)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.联系方式)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.单位编号)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.身份证号)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.项目单价)
                .HasPrecision(8, 2);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.项目名称)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.体检小结)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.科室)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.检查状态)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.备注)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.单位分组)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.套餐名称)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.项目编号)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.外送项目)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.介绍人)
                .IsUnicode(false);
        }
    }
}
