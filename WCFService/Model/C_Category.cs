namespace WCFService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Category")]
    public partial class C_Category
    {
        public C_Category()
        {
            C_Product = new HashSet<C_Product>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public DateTime? timestamp { get; set; }

        public virtual ICollection<C_Product> C_Product { get; set; }
    }
}
