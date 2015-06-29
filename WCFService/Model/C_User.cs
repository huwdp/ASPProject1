namespace WCFService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_User")]
    public partial class C_User
    {
        public C_User()
        {
            C_Basket = new HashSet<C_Basket>();
            C_Order = new HashSet<C_Order>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string username { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        public DateTime? timestamp { get; set; }

        public virtual ICollection<C_Basket> C_Basket { get; set; }

        public virtual ICollection<C_Order> C_Order { get; set; }
    }
}
