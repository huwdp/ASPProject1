namespace WCFService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C_Basket> C_Basket { get; set; }
        public virtual DbSet<C_Category> C_Category { get; set; }
        public virtual DbSet<C_Order> C_Order { get; set; }
        public virtual DbSet<C_OrderItem> C_OrderItem { get; set; }
        public virtual DbSet<C_Product> C_Product { get; set; }
        public virtual DbSet<C_User> C_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_Category>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Category>()
                .HasMany(e => e.C_Product)
                .WithOptional(e => e.C_Category)
                .HasForeignKey(e => e.categoryId);

            modelBuilder.Entity<C_Order>()
                .Property(e => e.money)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Order>()
                .HasMany(e => e.C_OrderItem)
                .WithOptional(e => e.C_Order)
                .HasForeignKey(e => e.orderId);

            modelBuilder.Entity<C_Product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Product>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<C_Product>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<C_Product>()
                .HasMany(e => e.C_Basket)
                .WithOptional(e => e.C_Product)
                .HasForeignKey(e => e.productId);

            modelBuilder.Entity<C_Product>()
                .HasMany(e => e.C_OrderItem)
                .WithOptional(e => e.C_Product)
                .HasForeignKey(e => e.productId);

            modelBuilder.Entity<C_User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<C_User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<C_User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<C_User>()
                .HasMany(e => e.C_Basket)
                .WithOptional(e => e.C_User)
                .HasForeignKey(e => e.userId);

            modelBuilder.Entity<C_User>()
                .HasMany(e => e.C_Order)
                .WithOptional(e => e.C_User)
                .HasForeignKey(e => e.userId);
        }
    }
}
