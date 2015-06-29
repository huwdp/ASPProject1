namespace WCFService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Basket")]
    public partial class C_Basket
    {
        public int id { get; set; }

        public int? userId { get; set; }

        public int? productId { get; set; }

        public virtual C_Product C_Product { get; set; }

        public virtual C_User C_User { get; set; }
    }
}
