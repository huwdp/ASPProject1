namespace WCFService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_Payment")]
    public partial class C_Payment
    {
        public C_Payment()
        {
            C_Order = new HashSet<C_Order>();
        }

        public int id { get; set; }

        public int? paypalId { get; set; }

        public int? visaId { get; set; }

        public decimal? money { get; set; }

        public virtual ICollection<C_Order> C_Order { get; set; }

        public virtual C_Visa C_Visa { get; set; }

        public virtual C_Paypal C_Paypal { get; set; }
    }
}
