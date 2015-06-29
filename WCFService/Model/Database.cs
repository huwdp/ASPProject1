namespace WCFService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<C_Basket> C_Basket { get; set; }
        public virtual DbSet<C_Category> C_Category { get; set; }
        public virtual DbSet<C_Order> C_Order { get; set; }
        public virtual DbSet<C_OrderItem> C_OrderItem { get; set; }
        public virtual DbSet<C_Payment> C_Payment { get; set; }
        public virtual DbSet<C_Paypal> C_Paypal { get; set; }
        public virtual DbSet<C_Product> C_Product { get; set; }
        public virtual DbSet<C_User> C_User { get; set; }
        public virtual DbSet<C_Visa> C_Visa { get; set; }

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
                .Property(e => e.houseName)
                .IsUnicode(false);

            modelBuilder.Entity<C_Order>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<C_Order>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<C_Order>()
                .Property(e => e.postCode)
                .IsUnicode(false);

            modelBuilder.Entity<C_Order>()
                .Property(e => e.county)
                .IsUnicode(false);

            modelBuilder.Entity<C_Order>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<C_Order>()
                .HasMany(e => e.C_OrderItem)
                .WithOptional(e => e.C_Order)
                .HasForeignKey(e => e.orderId);

            modelBuilder.Entity<C_Payment>()
                .Property(e => e.money)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C_Payment>()
                .HasMany(e => e.C_Order)
                .WithOptional(e => e.C_Payment)
                .HasForeignKey(e => e.paymentId);

            modelBuilder.Entity<C_Paypal>()
                .HasMany(e => e.C_Payment)
                .WithOptional(e => e.C_Paypal)
                .HasForeignKey(e => e.visaId);

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

            modelBuilder.Entity<C_Visa>()
                .HasMany(e => e.C_Payment)
                .WithOptional(e => e.C_Visa)
                .HasForeignKey(e => e.paypalId);
        }
    }
}
