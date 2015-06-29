namespace WCFService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Product")]
    public partial class C_Product
    {
        public C_Product()
        {
            C_Basket = new HashSet<C_Basket>();
            C_OrderItem = new HashSet<C_OrderItem>();
        }

        public int id { get; set; }

        public int? categoryId { get; set; }

        public decimal? price { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        public DateTime? timestamp { get; set; }

        public virtual ICollection<C_Basket> C_Basket { get; set; }

        public virtual C_Category C_Category { get; set; }

        public virtual ICollection<C_OrderItem> C_OrderItem { get; set; }
    }
}
