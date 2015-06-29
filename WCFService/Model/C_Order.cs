namespace WCFService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Order")]
    public partial class C_Order
    {
        public C_Order()
        {
            C_OrderItem = new HashSet<C_OrderItem>();
        }

        public int id { get; set; }

        public int? userId { get; set; }

        public int? paymentId { get; set; }

        public int? houseNumber { get; set; }

        [StringLength(255)]
        public string houseName { get; set; }

        [StringLength(255)]
        public string address1 { get; set; }

        [StringLength(255)]
        public string address2 { get; set; }

        [StringLength(255)]
        public string postCode { get; set; }

        [StringLength(255)]
        public string county { get; set; }

        [StringLength(255)]
        public string country { get; set; }

        public DateTime? timestamp { get; set; }

        public virtual C_Payment C_Payment { get; set; }

        public virtual C_User C_User { get; set; }

        public virtual ICollection<C_OrderItem> C_OrderItem { get; set; }
    }
}
