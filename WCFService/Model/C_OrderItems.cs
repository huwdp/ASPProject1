namespace WCFService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_OrderItems")]
    public partial class C_OrderItems
    {
        public int id { get; set; }

        public int? orderId { get; set; }

        public int? productId { get; set; }

        public virtual C_Order C_Order { get; set; }

        public virtual C_Product C_Product { get; set; }
    }
}
