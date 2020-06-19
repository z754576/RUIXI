namespace RXcx03._07.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<VIEW_DJCX123> VIEW_DJCX123 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
                .Property(e => e.项目单价)
                .HasPrecision(8, 2);

            modelBuilder.Entity<VIEW_DJCX123>()
                .Property(e => e.项目名称)
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
        }
    }
}
